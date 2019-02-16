/*
? Create Dictionary of 2 values.
*/
Dictionary<string, string> Listofpeople = new Dictionary<string, string>() 
        {
            {"Sri","Harsha"},
            {"Bomballi","Mexamon"},
            {"Nagendra","Moday"},
            {"Bully","Cath"},
            {"Raful","Gooli"}
        };

OR
var myDict = new Dictionary<string, string>
    {
        {"Sri","Harsha"},
        {"Bomballi","Mexamon"},
        {"Nagendra","Moday"},
        {"Bully","Cath"},
        {"Raful","Gooli"}
    }
/*
! Elements have to accessed by myDict["Sri"] as the Dictionary is Strong-typed.
 */

/*
? Create List of peoples first and last names separately in separate lists.
? Can be accessed by string_f[0 to 4]
? Can be accessed by string_l[0 to 4]
 */
 var string_f = new List<string>() {"Sri","Boohubal","Nahendra","Bella","Rauul"};
 var string_l = new List<string>() {"Whorsha","Minimum","mothi","Cat","Gandi"};
