using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ToDoProject
{
    public class Program
    {
        static List<Card> toDoCards = new List<Card>();
        static List<Card> inProgressCards = new List<Card>();
        static List<Card> doneCards = new List<Card>();

        static Dictionary<int, string> teamMembers = new Dictionary<int, string>
            {
                { 1, "Ahmet" },
                { 2, "Mehmet" },
                { 3, "Ayşe" },
                { 4, "Fatma" },
                { 5, "Ali" },
                { 6, "Zeynep" }
            };

       
        public static void Main(string[] args)
        {
            int choice = 0;
            Card card = new Card();
            card.Header = "software project";
            card.Content = "project is about e-commerce website";
            card.TeamMember = "tiga information";
            card.Size = Card.CardSize.XS;

            toDoCards.Add(card);

            while (choice != 5)
            {
                ShowMenu();


                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ListBoard();
                        break;
                    case 2:
                        AddCard();
                        break;
                    case 3:
                        DeleteCard();
                        break;
                    case 4:
                        MoveCard();
                        break;
                    case 5:
                        Console.WriteLine("Çıkış yapılıyor");
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız!");
                        break;
                }
            }

            Console.ReadLine();
        }


        public static void ShowMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(5) Çıkış");
        }

        public static void ListBoard()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            ListCards(toDoCards);

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            ListCards(inProgressCards);

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            ListCards(doneCards);
        }

        public static void ListCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine($"Başlık      : {card.Header}");
                Console.WriteLine($"İçerik      : {card.Content}");
                Console.WriteLine($"Atanan Kişi : {card.TeamMember}");
                Console.WriteLine($"Büyüklük    : {card.Size}");
                Console.WriteLine();
            }
        }

        public static void AddCard()
        {
            Console.WriteLine("Başlık Giriniz: ");
            string header = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz: ");
            string content = Console.ReadLine();

            Console.WriteLine("Takım üyeleri:");
            foreach (var item in teamMembers)
            {
                Console.WriteLine($"ID: {item.Key} İsim: {item.Value}");
            }

            Console.WriteLine("Kişi Seçiniz (ID): ");
            int teamMemberID = Convert.ToInt32(Console.ReadLine());

            if (teamMembers.TryGetValue(teamMemberID, out string teamMemberName))
            {
                Console.WriteLine("Büyüklük Seçiniz -> XS(1), S(2), M(3), L(4), XL(5): ");
                int size = Convert.ToInt32(Console.ReadLine());

                Card newCard = new Card();
                newCard.Header = header;
                newCard.Content = content;
                newCard.TeamMember = teamMemberName;
                newCard.Size = (Card.CardSize)size;
                toDoCards.Add(newCard);
                Console.WriteLine("Kart başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine("Geçersiz takım üyesi ID'si!");
            }
        }

        public static void DeleteCard()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string titleInput = Console.ReadLine();

            if (DeleteCardByTitle(titleInput, toDoCards) || DeleteCardByTitle(titleInput, inProgressCards) || DeleteCardByTitle(titleInput, doneCards))
            {
                Console.WriteLine("Kart başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart bulunamadı.");
            }
        }

        public static bool DeleteCardByTitle(string title, List<Card> cardList)
        {
            Card cardToDelete = cardList.FirstOrDefault(card => card.Header == title);
            if (cardToDelete != null)
            {
                cardList.Remove(cardToDelete);
                return true;
            }
            return false;
        }

        public static void MoveCard()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string titleInput = Console.ReadLine();

            if (MoveCardToAnotherList(titleInput, toDoCards, inProgressCards) ||
                MoveCardToAnotherList(titleInput, inProgressCards, doneCards))
            {
                Console.WriteLine("Kart başarıyla taşındı.");
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart bulunamadı.");
            }
        }

        public static bool MoveCardToAnotherList(string title, List<Card> sourceList, List<Card> destinationList)
        {
            Card cardToMove = sourceList.FirstOrDefault(card => card.Header == title);
            if (cardToMove != null)
            {
                sourceList.Remove(cardToMove);
                destinationList.Add(cardToMove);
                return true;
            }
            return false;



        }

        public class Card
        {
            public string Header { get; set; }
            public string Content { get; set; }
            public string TeamMember { get; set; }
            public CardSize Size { get; set; }
            public Type CardLine { get; set; }




            public enum CardSize
            {
                XS = 1,
                S = 2,
                M = 3,
                L = 4,
                XL = 5
            }

            public enum Type
            {
                TODO = 1,
                INPROGRESS = 2,
                DONE = 3
            }
        }
    }
}

