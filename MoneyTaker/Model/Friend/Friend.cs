using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Friend
    {
    String name;
    String email;
    String group;
    int credibility;

    String uguid;
    String gguid;
    int tag;

    public Friend(string name, string email, string group, int credibility, string uguid, string gguid, int tag)
    {
        this.name = name;
        this.email = email;
        this.group = group;
        this.credibility = credibility;
        this.uguid = uguid;
        this.gguid = gguid;
        this.tag = tag;
    }

    public string Name { get => name; set => name = value; }
    public string Email { get => email; set => email = value; }
    public string Group { get => group; set => group = value; }
    public int Credibility { get => credibility; set => credibility = value; }
    public string Uguid { get => uguid; set => uguid = value; }
    public string Gguid { get => gguid; set => gguid = value; }
    public int Tag { get => tag; set => tag = value; }
}

