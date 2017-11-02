using Android.App;
using Android.Content;
using ListaDesejos.Interfaces;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(ListaDesejos.Droid.Share))]
namespace ListaDesejos.Droid
{
    public class Share : IShare
    {
        private readonly Context _context;
        public Share()
        {
            _context = Application.Context;
        }
        public Task Show(string title, string message)
        {
            var contentType = "text/plain";
            var intent = new Intent(Intent.ActionSend);
            intent.SetType(contentType);
            intent.PutExtra(Intent.ExtraText, message ?? string.Empty);
            intent.PutExtra(Intent.ExtraSubject, title ?? string.Empty);
            var chooserIntent = Intent.CreateChooser(intent, title ?? string.Empty);
            chooserIntent.SetFlags(ActivityFlags.ClearTop);
            chooserIntent.SetFlags(ActivityFlags.NewTask);
            _context.StartActivity(chooserIntent);
            return Task.FromResult(true);
        }
    }
}