using System;

namespace To_Do_App
{
    public class Member
    {
        public int Id { get; set; }
        public string Mem_name { get; set; }
        public Member(int ıd, string mem_name)
        {
            this.Id = ıd;
            this.Mem_name = mem_name;
        }

    }
}