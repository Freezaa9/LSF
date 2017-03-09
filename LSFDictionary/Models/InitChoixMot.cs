﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LSFDictionary.Models
{
    public class InitChoixMot : DropCreateDatabaseAlways<BddContext>
    {
        protected override void Seed(BddContext context)
        {
            context.Dictionaries.Add(new Dictionary { Id = 1, Key = "Bonjour", Value = "../Movies/DSCN1033.MOV", Cate = "Langage courant", Niveau = 1, FontAwe = "fa-comment" });
            context.Dictionaries.Add(new Dictionary { Id = 2, Key = "Je dois", Value = "../Movies/DSCN1031.MOV", Cate = "Langage courant", Niveau = 1, FontAwe = "fa-comment" });
            context.Dictionaries.Add(new Dictionary { Id = 3, Key = "Quelque chose", Value = "../Movies/DSCN1032.MOV", Cate = "Langage courant", Niveau = 1, FontAwe = "fa-comment" });
            context.Dictionaries.Add(new Dictionary { Id = 4, Key = "Je peux", Value = "../Movies/DSCN1030.MOV", Cate = "Langage courant", Niveau = 1, FontAwe = "fa-comments" });
            context.Dictionaries.Add(new Dictionary { Id = 5, Key = "Merci", Value = "../Movies/DSCN1034.MOV", Cate = "Langage courant", Niveau = 1, FontAwe = "fa-comment" });
            context.Dictionaries.Add(new Dictionary { Id = 6, Key = "Ca va", Value = "../Movies/DSCN1035.MOV", Cate = "Langage courant", Niveau = 1, FontAwe = "fa-comment" });
            context.Dictionaries.Add(new Dictionary { Id = 7, Key = "Oui, merci", Value = "../Movies/DSCN1036.MOV", Cate = "Langage courant", Niveau = 1, FontAwe = "fa-comment" });
            context.Dictionaries.Add(new Dictionary { Id = 8, Key = "Apprendre", Value = "../Movies/apprendre.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 9, Key = "Compris", Value = "../Movies/compris.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 10, Key = "Crayon", Value = "../Movies/crayon.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 11, Key = "Difficile", Value = "../Movies/difficile.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 12, Key = "Ecole", Value = "../Movies/ecole.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 13, Key = "Essayer", Value = "../Movies/essayer.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 14, Key = "Facile", Value = "../Movies/facile.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 15, Key = "Faire", Value = "../Movies/faire.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 16, Key = "Important", Value = "../Movies/important.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 17, Key = "Lire", Value = "../Movies/lire.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 18, Key = "Oublier", Value = "../Movies/oublier.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 19, Key = "Probleme(Exercice)", Value = "../Movies/problemeExercice.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 20, Key = "Probleme(Difficulté)", Value = "../Movies/problemeDifficulte.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 21, Key = "Rater", Value = "../Movies/rater.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 22, Key = "Repondre", Value = "../Movies/repondre.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 22, Key = "Reussir", Value = "../Movies/reussir.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 24, Key = "Stylo", Value = "../Movies/stylo.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 25, Key = "Travailler", Value = "../Movies/travailler.MOV", Cate = "A l'école", Niveau = 1, FontAwe = "Graduation-Cap" });
            context.Dictionaries.Add(new Dictionary { Id = 26, Key = "Bouche", Value = "../Movies/bouche.MOV", Cate = "Anatomie", Niveau = 1, FontAwe = "fa-child" });
            context.Dictionaries.Add(new Dictionary { Id = 27, Key = "Bras", Value = "../Movies/bras.MOV", Cate = "Anatomie", Niveau = 1, FontAwe = "fa-child" });
            context.Dictionaries.Add(new Dictionary { Id = 28, Key = "Cerveau", Value = "../Movies/cerveau.MOV", Cate = "Anatomie", Niveau = 1, FontAwe = "fa-child" });
            context.Dictionaries.Add(new Dictionary { Id = 29, Key = "Corps", Value = "../Movies/corps.MOV", Cate = "Anatomie", Niveau = 1, FontAwe = "fa-child" });
            context.Dictionaries.Add(new Dictionary { Id = 30, Key = "Dent", Value = "../Movies/dent.MOV", Cate = "Anatomie", Niveau = 1, FontAwe = "fa-child" });
            context.Dictionaries.Add(new Dictionary { Id = 31, Key = "Doigts", Value = "../Movies/doigt.MOV", Cate = "Anatomie", Niveau = 1, FontAwe = "fa-child" });
            context.Dictionaries.Add(new Dictionary { Id = 32, Key = "Jambe", Value = "../Movies/jambe.MOV", Cate = "Anatomie", Niveau = 1, FontAwe = "fa-child" });
            context.Dictionaries.Add(new Dictionary { Id = 33, Key = "Levre", Value = "../Movies/levre.MOV", Cate = "Anatomie", Niveau = 1, FontAwe = "fa-child" });
            context.Dictionaries.Add(new Dictionary { Id = 34, Key = "Main", Value = "../Movies/main.MOV", Cate = "Anatomie", Niveau = 1, FontAwe = "fa-child" });
            context.Dictionaries.Add(new Dictionary { Id = 35, Key = "Animal", Value = "../Movies/animal.MOV", Cate = "Animaux", Niveau = 1, FontAwe = "fa-bug" });
            context.Dictionaries.Add(new Dictionary { Id = 36, Key = "Chien", Value = "../Movies/chien.MOV", Cate = "Animaux", Niveau = 1, FontAwe = "fa-bug" });
            context.Dictionaries.Add(new Dictionary { Id = 37, Key = "Chat", Value = "../Movies/chat.MOV", Cate = "Animaux", Niveau = 1, FontAwe = "fa-bug" });
            context.Dictionaries.Add(new Dictionary { Id = 38, Key = "Cheval", Value = "../Movies/cheval.MOV", Cate = "Animaux", Niveau = 1, FontAwe = "fa-bug" });
            context.Dictionaries.Add(new Dictionary { Id = 39, Key = "Oiseau", Value = "../Movies/oiseau.MOV", Cate = "Animaux", Niveau = 1, FontAwe = "fa-bug" });
            context.Dictionaries.Add(new Dictionary { Id = 40, Key = "Moustique", Value = "../Movies/moustique.MOV", Cate = "Animaux", Niveau = 1, FontAwe = "fa-bug" });
            context.Dictionaries.Add(new Dictionary { Id = 41, Key = "Poisson", Value = "../Movies/poisson.MOV", Cate = "Animaux", Niveau = 1, FontAwe = "fa-bug" });
            context.Dictionaries.Add(new Dictionary { Id = 42, Key = "Café", Value = "../Movies/cafe.MOV", Cate = "Boissons", Niveau = 1, FontAwe = "fa-glass" });
            context.Dictionaries.Add(new Dictionary { Id = 43, Key = "Thé", Value = "../Movies/the.MOV", Cate = "Boissons", Niveau = 1, FontAwe = "fa-glass" });
            context.Dictionaries.Add(new Dictionary { Id = 44, Key = "Eau", Value = "../Movies/eau.MOV", Cate = "Boissons", Niveau = 1, FontAwe = "fa-glass" });
            context.Dictionaries.Add(new Dictionary { Id = 45, Key = "Soleil", Value = "../Movies/soleil.MOV", Cate = "Climat", Niveau = 1, FontAwe = "fa-sun-o" });

            context.Letters.Add(new Letter { Id = 1, Key = "A", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 2, Key = "B", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 3, Key = "C", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 4, Key = "D", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 5, Key = "E", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 6, Key = "F", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 7, Key = "G", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 8, Key = "H", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 9, Key = "I", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 10, Key = "J", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 11, Key = "K", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 12, Key = "L", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 13, Key = "M", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 14, Key = "N", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 15, Key = "O", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 16, Key = "P", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 17, Key = "Q", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 18, Key = "R", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 19, Key = "S", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 20, Key = "T", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 21, Key = "U", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 22, Key = "V", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 23, Key = "W", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 24, Key = "X", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 25, Key = "Y", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 26, Key = "Z", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            /*context.Letters.Add(new Letter { Id = 27, Key = "-", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 28, Key = "'", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });
            context.Letters.Add(new Letter { Id = 29, Key = " ", Value = "../Movies/DSCN1033.MOV", FontAwe = "fa-comment" });*/
           

            ;


            /*
                    context.Dictionaries.Add(new Dictionary { Id = 46, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 47, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 48, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 49, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 50, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 51, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 52, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 53, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 54, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 55, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 56, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 57, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 58, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 59, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 60, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 61, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 62, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 63, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 64, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 65, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 66, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 67, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 68, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 69, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 70, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 71, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 72, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 73, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 74, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 75, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 76, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 77, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 78, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 79, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 80, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 81, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 82, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 83, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 84, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 85, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 86, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 87, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 88, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 89, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 90, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 91, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 92, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 93, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 94, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 95, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 96, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 97, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 98, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 99, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 100, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 101, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 102, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 103, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 104, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 105, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 106, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 107, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 108, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 109, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 110, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 111, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 112, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 113, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 114, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 115, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 116, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 117, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 118, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 119, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 120, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 121, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 122, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 123, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 124, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 125, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 126, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 127, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 128, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 129, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 130, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 131, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 132, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 133, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 134, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 135, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 136, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 137, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 138, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 139, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 140, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 141, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 142, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 143, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 144, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 145, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 146, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 147, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 148, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 149, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 150, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 151, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 152, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 153, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 154, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 155, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 156, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 157, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 158, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 159, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 160, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 161, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 162, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 163, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 164, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 165, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 166, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 167, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 168, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 169, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 170, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 171, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 172, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 173, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 174, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 175, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 176, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 177, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 178, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 179, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 180, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 181, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 182, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 183, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });
                    context.Dictionaries.Add(new Dictionary { Id = 184, Key = "Crayon", Value = "../Movies/DSCN1032.MOV" });*/

            base.Seed(context);
        }
    }
}