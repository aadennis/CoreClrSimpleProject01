using Xunit;
using System;
using ViewModel;
using Model;

namespace ComposerTests
{
    public class ComposerComplexPropertyTests {
        
        Composer _Composer;
        
        public ComposerComplexPropertyTests() {
            TestInitialize();
        }

        [Fact]
        public void WrapperSetsLifeDatesInModel() {
            var composerWrapper = new ComposerWrapper(_Composer);
            composerWrapper.composer.LifeDates = new LifeSpan{DateOfBirth = new DateTime(1688,4,4), DateOfDeath = new DateTime(1722,5,5)};
             Assert.Equal(composerWrapper.composer.LifeDates, _Composer.LifeDates);
             Assert.Equal(_Composer.LifeDates.DateOfBirth, new DateTime(1688,4,4));
             Assert.Equal(_Composer.LifeDates.DateOfDeath, new DateTime(1722,5,5));
             
        }
        
        [Fact]
        public void WrapperPropertiesReferenceComposerModelProperties() {
            var composerWrapper = new ComposerWrapper(_Composer);
            Assert.Equal("Edwards", composerWrapper.composer.LastName);
            Assert.Equal(_Composer.FirstName, composerWrapper.composer.FirstName);
        }
        
        [Fact]
        public void PassedComposerIsNotNull() {
            ViewModel.ComposerWrapper ComposerWrapper;
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => ComposerWrapper = new ComposerWrapper(null));
            var exceptionMessage = ex.ParamName;
            Assert.Equal("composer must not be null", exceptionMessage);
        }
        
        [Fact]
        public void ComposerViewModelSetsModelProperties() {
            var composerWrapper = new ComposerWrapper(_Composer);
            composerWrapper.FirstName = "Harold";
            composerWrapper.LastName = "MacMillan";
            
            Assert.Equal(composerWrapper.FirstName, _Composer.FirstName);
            Assert.Equal(composerWrapper.LastName, _Composer.LastName);
            
        }
        
        
        
        private void TestInitialize() {
             _Composer = new Model.Composer{FirstName = "Tom", LastName = "Edwards", LifeDates = new LifeSpan{DateOfBirth = new DateTime(1688,12,4), DateOfDeath = new DateTime(1722,1,18)}};
        }
    }
}