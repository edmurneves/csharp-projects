namespace ex_08;

class Aluno {
    public string Name { get; set; }
    public string Email { get; set; }
    public int Room { get; set; }

    public Aluno(string name, string email, int room) {
        Name = name;
        Email = email;
        Room = room;
    }
}