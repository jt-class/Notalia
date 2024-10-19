#if ANDROID
using Microsoft.Maui.Handlers;
using Android.Widget;
using Android.Graphics.Drawables;
using Android.OS;
using System.Runtime.Versioning;

namespace Notalia
{
    public class CustomEntryHandler : EntryHandler
    {
        public static IPropertyMapper<Entry, CustomEntryHandler> CustomMapper = new PropertyMapper<Entry, CustomEntryHandler>(EntryHandler.Mapper)
        {
            [nameof(Entry)] = MapCustomEntry // Map a custom method for Entry properties
        };

        public CustomEntryHandler() : base(CustomMapper)
        {
        }
        [SupportedOSPlatform("android")]
        public static void MapCustomEntry(CustomEntryHandler handler, Entry entry)
        {
            if (handler.PlatformView is EditText nativeEditText)
            {
                // Set the background to white
                nativeEditText.SetBackgroundColor(Android.Graphics.Color.White);

                // Remove the underline on Android by setting background to a ColorDrawable
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Q)
                {
                    nativeEditText.SetOutlineSpotShadowColor(Android.Graphics.Color.Transparent);
                }
                else
                {
                    nativeEditText.Background = new ColorDrawable(Android.Graphics.Color.White);
                }
            }
        }
    }
}
#endif
