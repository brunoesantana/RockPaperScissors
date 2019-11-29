using NUnit.Framework;
using RockPaperScissors.Business.Business;
using RockPaperScissors.CrossCutting.Builder;
using RockPaperScissors.CrossCutting.Exceptions;
using RockPaperScissors.CrossCutting.Helpers;
using System.Linq;

namespace RockPaperScissors.Tests
{
    public class FileTest
    {
        private const string VALID_INPUT_FILE = @"\Resources\valid_input.txt";
        private const string INVALID_INPUT_FILE = @"\Resources\invalid_input.txt";
        private const string EMPTY_INPUT_FILE = @"\Resources\empty.txt";
        private const string INVALID_PATH = @"\Resources\Test\invalid_input.txt";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Deve_ler_arquivo_de_entrada_corretamente_e_gerar_lista_string()
        {
            var stringPlayersList = FileHelper.ReadFile(FileHelper.GetFilePath(VALID_INPUT_FILE));

            Assert.IsTrue(stringPlayersList.Any());
        }

        [Test]
        public void Deve_lancar_excecao_se_arquivo_de_entrada_nao_for_encontrado()
        {
            var ex = Assert.Throws<FileException>(() => FileHelper.ReadFile(FileHelper.GetFilePath(INVALID_PATH)));
            Assert.AreEqual(ex.Message, "File not found");
        }

        [Test]
        public void Deve_lancar_excecao_se_arquivo_de_entrada_for_vazio()
        {
            var ex = Assert.Throws<FileException>(() => FileHelper.ReadFile(FileHelper.GetFilePath(EMPTY_INPUT_FILE)));
            Assert.AreEqual(ex.Message, "Empty file");
        }

        [Test]
        public void Deve_lancar_excecao_se_arquivo_de_entrada_for_invalido()
        {
            var stringPlayersList = FileHelper.ReadFile(FileHelper.GetFilePath(INVALID_INPUT_FILE));
            var players = new PlayerListBuilder().Build(stringPlayersList);

            var ex = Assert.Throws<NumberPlayersException>(() => new TournamentService().Start(new ConfrontationService().PrepareClashes(players)));
            Assert.AreEqual(ex.Message, "Invalid number of players");
        }
    }
}