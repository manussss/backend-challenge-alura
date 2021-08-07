using BackendChallengeAlura.Controllers;
using BackendChallengeAlura.Models;
using BackendChallengeAlura.Repositories;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Aluraflix.API.Tests
{
    public class CategoriaControllerTest
    {
        [Fact]
        public void AddCategoria()
        {
            var repo = new Mock<ICategoriaRepository>();
            repo.Setup(r => r.AddCategoria(It.IsAny<Categoria>()));

            var categoriaController = new CategoriaController(repo.Object);
            categoriaController.AddCategoria(new Categoria());

            repo.Verify(r => r.AddCategoria(It.IsAny<Categoria>()), Times.Once);
        }

        [Fact]
        public void GetCategoria()
        {
            var repo = new Mock<ICategoriaRepository>();
            repo.Setup(r => r.GetCategoria()).Returns(new List<Categoria>());

            var categoriaController = new CategoriaController(repo.Object);
            categoriaController.GetCategoria();

            repo.Verify(r => r.GetCategoria(), Times.Once);
        }

        [Fact]
        public void GetCategoriaById()
        {
            var repo = new Mock<ICategoriaRepository>();
            repo.Setup(r => r.GetCategoria(It.IsAny<int>()));

            var categoriaController = new CategoriaController(repo.Object);
            categoriaController.GetCategoria(1);

            repo.Verify(r => r.GetCategoria(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void UpdateCategoria()
        {
            var repo = new Mock<ICategoriaRepository>();
            repo.Setup(r => r.UpdateCategoria(It.IsAny<int>(), It.IsAny<Categoria>()));

            var categoriaController = new CategoriaController(repo.Object);
            categoriaController.UpdateCategoria(1, new Categoria());

            repo.Verify(r => r.UpdateCategoria(It.IsAny<int>(), It.IsAny<Categoria>()), Times.Once);
        }

        [Fact]
        public void DeleteCategoria()
        {
            var repo = new Mock<ICategoriaRepository>();
            repo.Setup(r => r.DeleteCategoria(It.IsAny<int>()));

            var categoriaController = new CategoriaController(repo.Object);
            categoriaController.DeleteCategoria(1);

            repo.Verify(r => r.DeleteCategoria(It.IsAny<int>()), Times.Once);
        }

    }
}
