using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using BayesOpt.Component;

using Grasshopper.Kernel;
using Grasshopper.Kernel.Data;
using Grasshopper.Kernel.Special;
using Grasshopper.Kernel.Types;

namespace BayesOpt.Util
{
    public class GrasshopperInOut
    {
        private readonly GH_Document _document;
        public List<GH_NumberSlider> Sliders;
        public List<Guid> InputGuids;
        public List<Variable> Variables;
        public List<IGH_Param> Objectives;
        public WithUI Component;
        public string ComponentFolder;
        public string DocumentPath;
        public string DocumentName;

        public GrasshopperInOut(WithUI component)
        {
            Component = component;
            ComponentFolder = Path.GetDirectoryName(Grasshopper.Instances.ComponentServer.FindAssemblyByObject(Component).Location);
            _document = Component.OnPingDocument();
            InputGuids = new List<Guid>();
        }

        public bool SetVariables()
        {
            Sliders = new List<GH_NumberSlider>();

            foreach (var source in Component.Params.Input[0].Sources)
            {
                InputGuids.Add(source.InstanceGuid);
            }

            if (InputGuids.Count == 0)
            {
                MessageBox.Show("No input variables found. Please connect a number slider to the input of the component.");
                return false;
            }

            foreach (Guid guid in InputGuids)
            {
                var input = _document.FindObject(guid, true);

                if (input is GH_NumberSlider slider)
                {
                    Sliders.Add(slider);
                }
            }

            SetSliderValues();
            return true;
        }

        private void SetSliderValues()
        {
            var variables = new List<Variable>();

            foreach (GH_NumberSlider slider in Sliders)
            {
                decimal min = slider.Slider.Minimum;
                decimal max = slider.Slider.Maximum;

                decimal lowerBond;
                decimal upperBond;
                bool isInteger;

                switch (slider.Slider.Type)
                {
                    case Grasshopper.GUI.Base.GH_SliderAccuracy.Even:
                        lowerBond = min / 2;
                        upperBond = max / 2;
                        isInteger = true;
                        break;
                    case Grasshopper.GUI.Base.GH_SliderAccuracy.Odd:
                        lowerBond = (min - 1) / 2;
                        upperBond = (max - 1) / 2;
                        isInteger = true;
                        break;
                    case Grasshopper.GUI.Base.GH_SliderAccuracy.Integer:
                        lowerBond = min;
                        upperBond = max;
                        isInteger = true;
                        break;
                    default:
                        lowerBond = min;
                        upperBond = max;
                        isInteger = false;
                        break;
                }

                variables.Add(new Variable(lowerBond, upperBond, isInteger));
            }

            Variables = variables;
        }

        public bool SetObjectives()
        {
            if (Component.Params.Input[1].SourceCount == 0)
            {
                MessageBox.Show("No objective found. Please connect a number to the objective of the component.");
                return false;
            }

            Objectives = Component.Params.Input[1].Sources.ToList();
            return true;
        }

        private bool SetSliderValues(IList<decimal> parameters)
        {
            int i = 0;

            foreach (GH_NumberSlider slider in Sliders)
            {
                if (slider == null)
                {
                    return false;
                }
                decimal val;

                switch (slider.Slider.Type)
                {
                    case Grasshopper.GUI.Base.GH_SliderAccuracy.Even:
                        val = (int)parameters[i++] * 2;
                        break;
                    case Grasshopper.GUI.Base.GH_SliderAccuracy.Odd:
                        val = (int)(parameters[i++] * 2) + 1;
                        break;
                    case Grasshopper.GUI.Base.GH_SliderAccuracy.Integer:
                        val = (int)parameters[i++];
                        break;
                    default:
                        val = parameters[i++];
                        break;
                }

                slider.Slider.RaiseEvents = false;
                slider.SetSliderValue(val);
                slider.ExpireSolution(false);
                slider.Slider.RaiseEvents = true;
            }

            return true;
        }

        private void Recalculate()
        {
            while (_document.SolutionState != GH_ProcessStep.PreProcess || _document.SolutionDepth != 0) { }

            _document.NewSolution(true);

            while (_document.SolutionState != GH_ProcessStep.PostProcess || _document.SolutionDepth != 0) { }
        }

        public void NewSolution(IList<decimal> parameters)
        {
            SetSliderValues(parameters);
            Recalculate();
        }

        public List<double> GetObjectiveValues()
        {
            var values = new List<double>();

            foreach (IGH_Param objective in Objectives)
            {
                IGH_StructureEnumerator ghEnumerator = objective.VolatileData.AllData(true);
                foreach (IGH_Goo goo in ghEnumerator)
                {
                    if (goo is GH_Number num)
                    {
                        values.Add(num.Value);
                    }
                }
            }

            return values;
        }
    }
}