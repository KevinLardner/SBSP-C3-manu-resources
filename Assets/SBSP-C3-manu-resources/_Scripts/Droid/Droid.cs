using UnityEngine;

public class Droid : Item
{

    private DroidModel _droidModel;

    public Droid()
    {
<<<<<<< HEAD
        _droidModel = new DroidModel();
        _droidView = new DroidView();
=======
        _droidModel = new RepairDroidModel();

    }

    public Droid(DroidModel model)
    {

        _droidModel = model;

>>>>>>> upstream/master
    }

    public DroidModel GetDroidModel()
    {
        return _droidModel;
<<<<<<< HEAD
=======
    }

    public void SetDroidModel(DroidModel model)
    {

        _droidModel = model;

    }

    public override bool UseItem(MainResourceController main , Item item)
    {
        return main.GetDroidManager().AddDroidToBay((Droid)item);
    }

    public virtual void PerformDroidAction()
    {

>>>>>>> upstream/master
    }

    public virtual void FinishDroidAction()
    {
<<<<<<< HEAD
        return _droidView;
    }
=======


    }

}

public enum DroidState
{
    Ready,
    Deployed,
    Charging,
    Repairing
}

public enum DroidType
{
    SearchDroid,
    RepairDroid
>>>>>>> upstream/master
}
