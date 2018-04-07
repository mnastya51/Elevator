using Elevator.AddAndEditForms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AnalysQualityRawController
    {
        public void addButtonClick(GeneralLevelOfQuality generalLevelOfQuality, string[] change, LinkedList<string> impurities)
        {//TypeHarmfulLevelOfQuality.NameTable, HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities
            string[] imp = DAO.getInstance().getImpurity(change[0], change[1], impurities);
            if (imp.Length > 0)
                new AddAnalysQualityRawForm(generalLevelOfQuality, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определено значение!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void addButtonClick(HarmfulLevelOfQuality harmfulLevelOfQuality, string[] change, LinkedList<string> impurities)
        {
            string[] imp = DAO.getInstance().getImpurity(change[0], change[1], impurities);
            if (imp.Length > 0)
                new AddAnalysQualityRawForm(harmfulLevelOfQuality, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определено значение!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void addButtonClick(GrainLevelOfQuality grainLevelOfQuality, string[] change, LinkedList<string> impurities)
        {
            string[] imp = DAO.getInstance().getImpurity(change[0], change[1], impurities);
            if (imp.Length > 0)
                new AddAnalysQualityRawForm(grainLevelOfQuality, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определено значение!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void addButtonClick(WeedLevelOfQuality weedLevelOfQuality, string[] change, LinkedList<string> impurities)
        {
            string[] imp = DAO.getInstance().getImpurity(change[0], change[1], impurities);
            if (imp.Length > 0)
                new AddAnalysQualityRawForm(weedLevelOfQuality, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определено значение!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
