using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroidManager : MonoBehaviour, IResearchEvent
{

    public Button createBayButton;
    public Text maxBayText;
    public GameObject bayPrefab;

    private DroidManagerModel _droidManagerModel;
    private DroidManagerView _droidManagerView;

    void Awake()
<<<<<<< HEAD
    {
        _droidManagerModel = new DroidManagerModel();
        createBayButton.onClick.AddListener(CreateNewBay);
        _droidManagerView = new DroidManagerView(createBayButton,maxBayText);
=======
    {    
        _droidManagerModel = new DroidManagerModel();
        createBayButton.onClick.AddListener(CreateNewBay);
        _droidManagerView = new DroidManagerView(createBayButton,maxBayText);


>>>>>>> upstream/master
    }

    void Start()
    {
        _droidManagerView.SetBayStatus(_droidManagerModel.GetCurrentSize(), _droidManagerModel.GetMaxBaySize());
<<<<<<< HEAD
=======
        SuscribeToResearchEvent(_droidManagerModel.GetMainController().GetResearchController());

>>>>>>> upstream/master
    }

    public DroidManagerModel GetDroidManagerModel()
    {
        return _droidManagerModel;
    }

    public void CreateNewBay()
    {
        if (_droidManagerModel.GetCurrentSize() < _droidManagerModel.GetMaxBaySize()) {

            GameObject newBayGameObject = Instantiate(bayPrefab);
            newBayGameObject.transform.SetParent(gameObject.transform);
            newBayGameObject.transform.localScale = new Vector3(1, 1, 1);

            DroidBay newBay = newBayGameObject.GetComponent<DroidBay>();
            newBay.GetDroidBayModel().SetDroidManager(this);
            newBay.GetDroidBayModel().SetBayIndex(_droidManagerModel.GetCurrentSize());
            newBay.gameObject.name = "DroidBay_" + newBay.GetDroidBayModel().GetBayIndex();

            _droidManagerModel.AddNewBay(newBay);
            _droidManagerModel.SetBaySize(_droidManagerModel.GetCurrentSize() + 1);

            _droidManagerView.SetBayStatus(_droidManagerModel.GetCurrentSize(), _droidManagerModel.GetMaxBaySize());
<<<<<<< HEAD
        }
    }
}
=======

            //suscribe to research event

        }

    }

    public bool AddDroidToBay(Droid droid)
    {

        for (int i = 0; i < _droidManagerModel.GetCurrentSize(); i++)
        {

            if (_droidManagerModel.GetDroidBay(i).AddDroidToBay(droid))
            {

                return true;

            }

        }

        return false;

    }

    public void OnResearchLearned()
    {
        if (_droidManagerModel.GetMainController().GetResearchController().IsResearchLearned(AllResearches.More_Bays))
        {

            _droidManagerModel.SetMaxBaySize(4);
            _droidManagerView.SetBayStatus(_droidManagerModel.GetCurrentSize(), _droidManagerModel.GetMaxBaySize());

        }
    }

    public void SuscribeToResearchEvent(ResearchPanelController controller)
    {

        controller.onFinished += OnResearchLearned;

    }
}
>>>>>>> upstream/master
