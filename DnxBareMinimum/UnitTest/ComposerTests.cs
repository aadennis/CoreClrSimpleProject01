using Xunit;
using System;
using ViewModel;
using Model = Dennis.ComposerApp.Model;

namespace ComposerTests
{
    public class ComposerTests {
        
        Model.Composer _Composer;
        
        public ComposerTests() {
            TestInitialize();
        }

        [Fact]
        public void WrapperContainsComposerModel() {
            var composerWrapper = new ComposerWrapper(_Composer);
             Assert.Equal(_Composer, composerWrapper.composer);
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
             _Composer = new Model.Composer{FirstName = "Tom", LastName = "Edwards"};
        }
    }
}