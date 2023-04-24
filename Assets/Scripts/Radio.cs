using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public Task task;
    public MainDoors mainDoors;
    public GameObject cc;
    
    void Start()
    {
        FindObjectOfType<AudioMenager>().Play("Heartaches");
    }

    public void WarnAboutEntities()
    {
        StartCoroutine(Waiter());

    }
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(7); 
        FindObjectOfType<AudioMenager>().Stop("Heartaches");
        
        FindObjectOfType<AudioMenager>().Play("Warning");
        task.updateTask("Wysluchaj komunikatu");
        cc.SetActive(true);

        task.subtitles("Uwaga wszystkim sluchaczom, otrzymalismy zgloszenia o dziwnych istotach, ktore probuja dostac sie do domow w okolicy.");
        yield return new WaitForSecondsRealtime(7);

        task.subtitles("Apelujemy do wszystkich mieszkancow o czujnosc i podjecie niezbednych srodkow ostroznosci, aby zapewnic bezpieczenstwo sobie i swoim rodzinom.");
        yield return new WaitForSecondsRealtime(8);

        task.subtitles("Pod zadnym pozorem nie otwierajcie drzwi nikomu lub czemus, czego sie nie spodziewacie.");
        yield return new WaitForSecondsRealtime(10);

        task.subtitles("Te istoty moga przybierac rozne formy i probowac sklonic was do otwarcia drzwi, ale nie mozna im ufac.");
        yield return new WaitForSecondsRealtime(10);

        task.subtitles("Jesli zauwazysz cokolwiek podejrzanego, prosze niezwlocznie skontaktuj sie z wladzami.");
        yield return new WaitForSecondsRealtime(6);

        task.subtitles("Pamietaj, aby trzymac wszystkie drzwi i okna zamkniete oraz miec swiadomosc swojego otoczenia przez caly czas.");
        yield return new WaitForSecondsRealtime(6);

        task.subtitles("W razie kontaktu - odbierz sobie zycie.");
        yield return new WaitForSecondsRealtime(3);

        task.subtitles("Tak bedzie prosciej i szybciej");
        yield return new WaitForSecondsRealtime(3);

        task.subtitles("Prosimy traktowac to ostrzezenie powaznie i nie podejmowac niepotrzebnego ryzyka. Badzcie czujni i bezpieczni.");
        yield return new WaitForSecondsRealtime(8);

        cc.SetActive(false);
        

        yield return new WaitForSecondsRealtime(5); //48 tyle trwa komunikat
        mainDoors.KnockingOnHeavensDoor();
        task.updateTask("Co? Jakie 'istoty'?");
    }
}




