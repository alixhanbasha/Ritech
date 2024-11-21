
namespace Ritech.Pages {

    /*
     * A page that inherits the following class
     * shall be responsible for making sure that
     * it and its children are displayed
     */
    public interface Page {
        bool EnsureIsDisplayed();
    }

}