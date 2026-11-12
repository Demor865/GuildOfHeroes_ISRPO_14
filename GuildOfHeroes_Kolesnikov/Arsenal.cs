public class Arsenal {
    public string Name { get; private set; }
    private List<Weapon> _weapons { get; set; } = new List<Weapon>();

    public Arsenal(string name) {
        Name = name;
    }
    public bool AddWeapon(Weapon weapon) {
        if (FindWeaponByName(weapon.Name) != null) {
            return false;
        }
        _weapons.Add(weapon);
        return true;
    }
    public bool RemoveWeapon(string name) {
        Weapon? weapon = FindWeaponByName(name);
        if (weapon == null) {
            return false;
        }
        return _weapons.Remove(weapon);
    }

    public Weapon? FindWeaponByName(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }

        string searchName = name.Trim();

        foreach (Weapon weapon in _weapons) {
            if (string.Equals(weapon.Name, searchName, StringComparison.OrdinalIgnoreCase)) {
                return weapon;
            }
        }

        return null;
    }

    public List<Weapon> GetMembers_Weapon() {
        List<Weapon> result = new List<Weapon>();
        foreach (Weapon weapon in _weapons) {
            result.Add(weapon);
        }
        return result;
    }

    public int MemberCount_Weapon {
        get { return _weapons.Count; }
    }
}