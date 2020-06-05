namespace Snake_box
{
    public abstract class BaseTalent : ITalent
    {
        #region Fields

        protected int _level;
        private string _name;

        #endregion


        #region ClassLifeCycle

        public BaseTalent()
        {
            
            
            Load();
        }

        #endregion
        
        
        #region ITalent

        public abstract void Implenet();

        public void Load()
        {
            _level = Services.Instance.SaveData.GetInt(_name);
        }

        public void Save()
        {
            Services.Instance.SaveData.SetInt(_name,_level);
        }
        
        #endregion
    }
}
