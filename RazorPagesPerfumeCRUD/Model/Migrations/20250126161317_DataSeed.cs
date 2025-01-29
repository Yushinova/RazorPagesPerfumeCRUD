using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesPerfumeCRUD.Model.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Perfumes",
               columns: ["Id", "Name", "Brand", "Description", "Gender", "Notes", "Volume", "Price", "isSale"],
               values: new object[,]
               {
                    { 1, "Calme Absolu", "Essences Botaniques", "Аромат с теплыми нотами и свежим цветочным аккордом эфирного масла Лаванды, известного своими расслабляющими свойствами", "women", "лаванда, кедр, амирис, сандал", 50, 2900, false },
                    { 2, "Ondes Positives", "Essences Botaniques", "Аромат с освежающими нотами и искрящимся аккордом эфирного масла Лимона, известного своими бодрящими свойствами", "men", "мандарин, лимон, кипарис", 50, 2900, false },
                    { 3, "Bois de Sauge", "Bois de Sauge", "Энергия дерзкой свежести", "men", "шалфей, гваяковое дерево, пачули", 100, 3600, true },
                    { 4, "Ambre Noir", "Ambre Noir", "Сила мужского покорения выражена в этом аромате сочетанием мужественных пряных и жарких амбровых древесных нот", "men", "кардамон, корица, пачули", 100, 2900, false },
                    { 5, "Bois Imperial ", "ESSENTIAL PARFUMS PARIS", "Уникальное сочетание элегантности и энергии. Этот парфюм подходит как мужчинам, так и женщинам, которые стремятся подчеркнуть свою индивидуальность и деловую хватку", "unisex", "ветивер, амбра, пачули", 100, 14500, false },
               }
           );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int i = 1; i <= 11; i++)
            {
                migrationBuilder.DeleteData(
                    table: "Perfumes",
                    keyColumn: "Id",
                    keyValue: i
                );
            }
        }
    }
}
