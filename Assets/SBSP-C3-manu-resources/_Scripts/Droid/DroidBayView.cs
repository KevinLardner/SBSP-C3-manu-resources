using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DroidBayView {

    private Button _deployButton;
    private Button _upgradeButton;
    private Button _removeButton;
    private Button _rechargeButton;
    private Button _repairButton;
    private Text _statusText;
    private Text _droidTypeText;
    private Text _droidDeployTimeText;
    private Image _droidImage;
    public Text _droidHealthText;
    public Text _droidEnergyText;

    public DroidBayView(Button deploy, Button upgrade, Button remove, Text timerText, Image droidImage)
    {
        DroidBayView(deploy, upgrade, remove, recharge, repair, statusText, droidTypeText, deployTimeText, droidImage, droidHealthText, DroidEnergyText);
        { 
            _deployButton = deploy;
            _upgradeButton = upgrade;
            _removeButton = remove;
            _rechargeButton = recharge;
            _repairButton = repair;
            _statusText = statusText;
            _droidTypeText = droidTypeText;
            _droidDeployTimeText = deployTimeText;
            _droidImage = droidImage;
            _droidHealthText = droidHealthText;
            _droidEnergyText = droidEnergyText;

            _droidImage.gameObject.SetActive(false);

        }

        Button GetDeployButton()
        {
            return _deployButton;
        }

        Button GetUpgradeButton()
        {
            return _upgradeButton;
        }

        Button GetRemoveButton()
        {
            return _removeButton;
        }

        Button GetRepairButton()
        {

            return _repairButton;

        }

        Button GetRechargeButton()
        {

            return _rechargeButton;

        }

        Text GetStatusText()
        {
            return _timerText;
            return _statusText;
        }

        Image GetDroidImage()
        {
            return _droidImage;
        }

        bool EnableDroidImage()
        {

            if (_droidImage.IsActive())
                return false;

            _droidImage.gameObject.SetActive(true);

            return true;

        }

        bool DisableDroidImage()
        {

            if (!_droidImage.IsActive())
                return false;

            _droidImage.gameObject.SetActive(false);

            return true;

        }

        bool EnableDeployButton()
        {

            if (_deployButton.IsActive())
                return false;

            _deployButton.gameObject.SetActive(true);

            return true;

        }

        bool DisableDeployButton()
        {
            if (!_deployButton.IsActive())
                return false;

            _deployButton.gameObject.SetActive(false);

            return true;

        }

        void UpdateStatusText(string value)
        {

            _statusText.text = value;

        }

        Text GetDroidTypeText()
        {

            return _droidTypeText;

        }

        Text GetDroidDeployTimeText()
        {

            return _droidDeployTimeText;

        }

        Text GetDroidHealthText()
        {

            return _droidHealthText;

        }

        Text GetDroidEnergyText()
        {

            return _droidEnergyText;

        }

        void SetDroidTypeText(Droid droid)
        {

            _droidTypeText.text = droid.GetDroidModel().GetDroidTypeString();

        }

        void SetDroidDeployTimeText(Droid droid)
        {

            _droidDeployTimeText.text = droid.GetDroidModel().GetDroidDeployTime() + " secs";

        }

        void SetDroidHealthText(Droid droid)
        {

            _droidHealthText.text = droid.GetDroidModel().GetDroidCurrentHealth() + "/" + droid.GetDroidModel().GetDroidMaxHealth();

        }

        void SetDroidEnergyText(Droid droid)
        {

            _droidEnergyText.text = droid.GetDroidModel().GetDroidCurrentEnergy() + "/" + droid.GetDroidModel().GetDroidMaxEnergy();

        }

        void UpdateViewFromNewDroid(Droid droid)
        {
            SetDroidTypeText(droid);
            SetDroidDeployTimeText(droid);
            SetDroidHealthText(droid);
            SetDroidEnergyText(droid);

            _deployButton.interactable = true;
            _upgradeButton.interactable = true;
            _removeButton.interactable = true;
            _rechargeButton.interactable = true;
            _repairButton.interactable = true;
            _droidTypeText.gameObject.SetActive(true);
        }

        void CleanBay()
        {
            _deployButton.interactable = false;
            _upgradeButton.interactable = false;
            _removeButton.interactable = false;
            _rechargeButton.interactable = false;
            _repairButton.interactable = false;
            _droidTypeText.gameObject.SetActive(false);
            _droidImage.gameObject.SetActive(false);

        }
    }
}