using TestesUnitarios.Desafio.Console.Services;
using Xunit; // Não se esqueça de incluir o namespace do xUnit

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes = new ValidacoesString();

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            // Arrange
            var texto = "Matrix"; // Corrigido para a palavra "Matrix"
            var resultadoEsperado = 6; // Corrigido para 6 caracteres

            // Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            // Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "qualquer";

            // Act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado); // Corrigida a chamada do método

            // Assert
            Assert.True(resultado); // Corrigido para verificar o resultado do método
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            // Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "teste";

            // Act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            // Assert
            Assert.False(resultado); // Corrigido para verificar o resultado do método
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            // Arrange
            var texto = "Começo, meio e fim do texto procurado";
            var textoProcurado = "procurado"; // Corrigido para a palavra correta

            // Act
            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

            // Assert
            Assert.True(resultado);
        }
    }
}
