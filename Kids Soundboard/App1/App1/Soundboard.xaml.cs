using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Soundboard : Page
    {
        public Soundboard()
        {
            this.InitializeComponent();
        }

        // Animal Region
        #region
        // StackPanel 1 of Animals
        #region
        private async void Sound_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("bird.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound1_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("cat_growl.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound2_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("cow3.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound3_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("chicken.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound4_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("dog_bark.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }
        #endregion

        // StackPanel 2 of Animals
        #region
        private async void Sound5_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("dolphin.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound6_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("donkey.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound7_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("duck_quack.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound8_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("elephant.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound9_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("fly.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }
        #endregion

        //StackPanel 3 of Animals
        #region
        private async void Sound10_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("horse.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound11_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("lion_roar.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound12_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("monkey.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound13_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("rooster.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        private async void Sound14_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Animals");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("sheep.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }
        #endregion

        // StackPanel 1 of Animals spell checks and clues
        #region
        // Bird
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            if (textBox.Text.ToLower() == "bird")
            {
                ppup1.IsOpen = true;
                textBox.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox.Text = String.Empty;
            }
        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("B _ _ _");
            await message.ShowAsync();
        }

        // Cat
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.ToLower() == "cat")
            {
                ppup1.IsOpen = true;
                textBox1.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox1.Text = String.Empty;
            }
        }

        private async void button3_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("C _ _");
            await message.ShowAsync();
        }

        // Cow
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text.ToLower() == "cow")
            {
                ppup1.IsOpen = true;
                textBox2.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox2.Text = String.Empty;
            }
        }

        private async void button5_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ W");
            await message.ShowAsync();
        }

        // Chicken
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (textBox3.Text.ToLower() == "chicken")
            {
                ppup1.IsOpen = true;
                textBox3.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox3.Text = String.Empty;
            }
        }

        private async void button7_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ K _ N");
            await message.ShowAsync();
        }
        #endregion

        // StackPanel 2 of Animals spell checks and clues
        #region
        // Donkey
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (textBox4.Text.ToLower() == "dolphin")
            {
                ppup1.IsOpen = true;
                textBox4.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox4.Text = String.Empty;
            }
        }

        private async void button9_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog(" _ O _ _ H _ _");
            await message.ShowAsync();
        }

        // Donkey
        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (textBox5.Text.ToLower() == "donkey")
            {
                ppup1.IsOpen = true;
                textBox5.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox5.Text = String.Empty;
            }
        }

        private async void button11_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("D _ _ _ _ Y");
            await message.ShowAsync();
        }

        // Duck 
        private void button12_Click(object sender, RoutedEventArgs e)
        {
            if (textBox6.Text.ToLower() == "duck")
            {
                ppup1.IsOpen = true;
                textBox6.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox6.Text = String.Empty;
            }
        }

        private async void button13_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("D _ _ _");
            await message.ShowAsync();
        }

        // Elephant
        private void button14_Click(object sender, RoutedEventArgs e)
        {
            if (textBox7.Text.ToLower() == "elephant")
            {
                ppup1.IsOpen = true;
                textBox7.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox7.Text = String.Empty;
            }
        }

        private async void button15_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ L _ _ _ _ _ T");
            await message.ShowAsync();
        }
        #endregion

        // StackPanel 3 of Animals spell checks and clues
        #region
        // Horse
        private void button16_Click(object sender, RoutedEventArgs e)
        {
            if (textBox8.Text.ToLower() == "horse")
            {
                ppup1.IsOpen = true;
                textBox8.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox8.Text = String.Empty;
            }
        }

        private async void button17_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog(" _ O _ _ _");
            await message.ShowAsync();
        }

        // Lion
        private void button18_Click(object sender, RoutedEventArgs e)
        {
            if (textBox9.Text.ToLower() == "lion")
            {
                ppup1.IsOpen = true;
                textBox9.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox9.Text = String.Empty;
            }
        }

        private async void button19_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog(" L _ _ _");
            await message.ShowAsync();
        }

        // Monkey
        private void button20_Click(object sender, RoutedEventArgs e)
        {
            if (textBox10.Text.ToLower() == "monkey")
            {
                ppup1.IsOpen = true;
                textBox10.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox10.Text = String.Empty;
            }
        }

        private async void button21_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog(" _ _ _ _ _ Y");
            await message.ShowAsync();
        }

        // Rooster
        private void button22_Click(object sender, RoutedEventArgs e)
        {
            if (textBox11.Text.ToLower() == "rooster")
            {
                ppup1.IsOpen = true;
                textBox11.Text = String.Empty;
            }

            else
            {
                ppup2.IsOpen = true;
                textBox11.Text = String.Empty;
            }
        }

        private async void button23_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("R _ O _ _ _ _");
            await message.ShowAsync();
        }
        #endregion

        #endregion

        // Sport Region
        #region
        // All Sports Sounds
        #region
        private async void Sound14_Click_1(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Ball+Hit+Cheer.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();

        }

        private async void Sound15_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("BOUNCE+1.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound16_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("bowling3.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound17_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("diving.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound18_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("FOOTBALLKICK.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound19_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("golfball.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound20_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("pingpong.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound21_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Billiards+3.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound22_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("car+race.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound23_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("SNOWSK-1.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound24_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("tennisserve.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        private async void Sound25_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sports");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Boxing_Bell.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }
        #endregion

        // StackPanel 1 of Sports spell checks and clues
        #region
        // Baseball
        private void button24_Click(object sender, RoutedEventArgs e)
        {
            if (textBox12.Text.ToLower() == "baseball")
            {
                ppup3.IsOpen = true;
                textBox12.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox12.Text = String.Empty;
            }
        }

        private async void button25_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ E _ _ _ L");
            await message.ShowAsync();
        }

        // Basketball
        private void button26_Click(object sender, RoutedEventArgs e)
        {
            if (textBox15.Text.ToLower() == "basketball")
            {
                ppup3.IsOpen = true;
                textBox15.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox15.Text = String.Empty;
            }
        }

        private async void button27_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ K _ T _ _ _ _");
            await message.ShowAsync();
        }

        // Bowling
        private void button28_Click(object sender, RoutedEventArgs e)
        {
            if (textBox16.Text.ToLower() == "bowling")
            {
                ppup3.IsOpen = true;
                textBox16.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox16.Text = String.Empty;
            }
        }

        private async void button29_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("B _ _ _ _ _ _");
            await message.ShowAsync();
        }

        // Diving
        private void button30_Click(object sender, RoutedEventArgs e)
        {
            if (textBox17.Text.ToLower() == "diving")
            {
                ppup3.IsOpen = true;
                textBox17.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox17.Text = String.Empty;
            }
        }

        private async void button31_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ V _ _ _");
            await message.ShowAsync();
        }
        #endregion

        // StackPanel 2 of Sports spell checks and clues
        #region
        // Football
        private void button32_Click(object sender, RoutedEventArgs e)
        {
            if (textBox18.Text.ToLower() == "football")
            {
                ppup3.IsOpen = true;
                textBox18.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox18.Text = String.Empty;
            }
        }

        private async void button33_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ T _ _ _ _");
            await message.ShowAsync();
        }

        // Golf
        private void button34_Click(object sender, RoutedEventArgs e)
        {
            if (textBox19.Text.ToLower() == "golf")
            {
                ppup3.IsOpen = true;
                textBox19.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox19.Text = String.Empty;
            }
        }

        private async void button35_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _");
            await message.ShowAsync();
        }

        // PingPong / Table Tennis
        private void button36_Click(object sender, RoutedEventArgs e)
        {
            if (textBox20.Text.ToLower() == "pingpong" || textBox20.Text.ToLower() == "table tennis")
            {
                ppup3.IsOpen = true;
                textBox20.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox20.Text = String.Empty;
            }
        }

        private async void button37_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("P _ _ _ P _ _ _      OR    T _ _ _ _ _    _ _ _ _ _ S ");
            await message.ShowAsync();
        }

        // Pool
        private void button38_Click(object sender, RoutedEventArgs e)
        {
            if (textBox21.Text.ToLower() == "pool")
            {
                ppup3.IsOpen = true;
                textBox21.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox21.Text = String.Empty;
            }
        }

        private async void button39_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("P _ _ _");
            await message.ShowAsync();
        }
        #endregion

        // StackPanel 3 of Sports spell checks and clues
        #region
        // Racing Car
        private void button40_Click(object sender, RoutedEventArgs e)
        {
            if (textBox22.Text.ToLower() == "racing car")
            {
                ppup3.IsOpen = true;
                textBox22.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox22.Text = String.Empty;
            }
        }

        private async void button41_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ _ G  _ _ R");
            await message.ShowAsync();
        }

        // Skiing
        private void button42_Click(object sender, RoutedEventArgs e)
        {
            if (textBox23.Text.ToLower() == "skiing")
            {
                ppup3.IsOpen = true;
                textBox23.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox23.Text = String.Empty;
            }
        }

        private async void button43_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("S K _ _ _ _");
            await message.ShowAsync();
        }

        // Tennis
        private void button44_Click(object sender, RoutedEventArgs e)
        {
            if (textBox24.Text.ToLower() == "tennis")
            {
                ppup3.IsOpen = true;
                textBox24.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox24.Text = String.Empty;
            }
        }

        private async void button45_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ N _ _ _");
            await message.ShowAsync();
        }

        // Boxing
        private void button46_Click(object sender, RoutedEventArgs e)
        {
            if (textBox25.Text.ToLower() == "boxing")
            {
                ppup3.IsOpen = true;
                textBox25.Text = String.Empty;
            }

            else
            {
                ppup4.IsOpen = true;
                textBox25.Text = String.Empty;
            }
        }

        private async void button47_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ _ G");
            await message.ShowAsync();
        }

        #endregion
        #endregion


        // All Household Sounds
        #region
        // Aerosol Can
        private async void Sound26_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("aerosol+spray+shake.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Bottle
        private async void Sound27_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("bottleopen2.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Bubble
        private async void Sound28_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Bubble5.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Sink
        private async void Sound29_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Drains.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Clock
        private async void Sound30_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("clock-tick2.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Door
        private async void Sound31_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("doorcreaky.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Fan
        private async void Sound32_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("fan1.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Gate
        private async void Sound33_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("GATECLOS.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Hairdryer
        private async void Sound34_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Hairdryer1.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Lawn-Mower
        private async void Sound35_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("lawn-mower-05.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Phone
        private async void Sound36_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("phone_cellular.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        // Vacuum
        private async void Sound37_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Household");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Vacuum.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();
        }

        #endregion

        // StackPanel 1 of Household spell checks and clues
        #region
        // Aerosol Can
        private void button48_Click(object sender, RoutedEventArgs e)
        {
            if (textBox26.Text.ToLower() == "aerosol can")
            {
                ppup5.IsOpen = true;
                textBox26.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox26.Text = String.Empty;
            }
        }

        private async void button49_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ S _ _  C _ _");
            await message.ShowAsync();
        }

        // Bottle
        private void button50_Click(object sender, RoutedEventArgs e)
        {
            if (textBox27.Text.ToLower() == "bottle")
            {
                ppup5.IsOpen = true;
                textBox27.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox27.Text = String.Empty;
            }
        }

        private async void button51_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ _ _");
            await message.ShowAsync();
        }

        // Bubbles
        private void button52_Click(object sender, RoutedEventArgs e)
        {
            if (textBox28.Text.ToLower() == "bubbles")
            {
                ppup5.IsOpen = true;
                textBox28.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox28.Text = String.Empty;
            }
        }

        private async void button53_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ S _ _  C _ _");
            await message.ShowAsync();
        }

        // Sink
        private void button54_Click(object sender, RoutedEventArgs e)
        {
            if (textBox29.Text.ToLower() == "sink")
            {
                ppup5.IsOpen = true;
                textBox29.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox29.Text = String.Empty;
            }
        }

        private async void button55_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _");
            await message.ShowAsync();
        }
        #endregion

        // StackPanel 2 of Household spell checks and clues
        #region
        // Clock
        private void button56_Click(object sender, RoutedEventArgs e)
        {
            if (textBox30.Text.ToLower() == "clock")
            {
                ppup5.IsOpen = true;
                textBox30.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox30.Text = String.Empty;
            }
        }

        private async void button57_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ C _");
            await message.ShowAsync();
        }

        // Door
        private void button58_Click(object sender, RoutedEventArgs e)
        {
            if (textBox31.Text.ToLower() == "door")
            {
                ppup5.IsOpen = true;
                textBox31.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox31.Text = String.Empty;
            }
        }

        private async void button59_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _");
            await message.ShowAsync();
        }

        // Fan
        private void button60_Click(object sender, RoutedEventArgs e)
        {
            if (textBox32.Text.ToLower() == "fan")
            {
                ppup5.IsOpen = true;
                textBox32.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox32.Text = String.Empty;
            }
        }

        private async void button61_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _");
            await message.ShowAsync();
        }

        // Gate
        private void button62_Click(object sender, RoutedEventArgs e)
        {
            if (textBox33.Text.ToLower() == "gate")
            {
                ppup5.IsOpen = true;
                textBox33.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox33.Text = String.Empty;
            }
        }

        private async void button63_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _");
            await message.ShowAsync();
        }
        #endregion

        // StackPanel 3 of Household spell checks and clues
        #region
        // Hairdryer
        private void button64_Click(object sender, RoutedEventArgs e)
        {
            if (textBox34.Text.ToLower() == "hairdryer")
            {
                ppup5.IsOpen = true;
                textBox34.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox34.Text = String.Empty;
            }
        }

        private async void button65_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ _ _ _ _ R");
            await message.ShowAsync();
        }

        // Lawnmower
        private void button66_Click(object sender, RoutedEventArgs e)
        {
            if (textBox35.Text.ToLower() == "lawnmower")
            {
                ppup5.IsOpen = true;
                textBox35.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox35.Text = String.Empty;
            }
        }

        private async void button67_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("M _ _ _ _ _ _ E _");
            await message.ShowAsync();
        }

        // Phone
        private void button68_Click(object sender, RoutedEventArgs e)
        {
            if (textBox36.Text.ToLower() == "mobile phone")
            {
                ppup5.IsOpen = true;
                textBox36.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox36.Text = String.Empty;
            }
        }

        private async void button69_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ _ E  _ _ _ _ E");
            await message.ShowAsync();
        }

        // Vacuum
        private void button70_Click(object sender, RoutedEventArgs e)
        {
            if (textBox37.Text.ToLower() == "vacuum")
            {
                ppup5.IsOpen = true;
                textBox37.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox37.Text = String.Empty;
            }
        }

        private async void button71_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ _ _");
            await message.ShowAsync();
        }

        #endregion

        // All Instrument Sounds
        #region
        // Banjo
        private async void Sound38_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("banjo.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Guitar
        private async void Sound39_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Guitar.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Didgeridoo
        private async void Sound40_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("didgeridoo.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Drums
        private async void Sound41_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("drums.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Flute
        private async void Sound43_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("flute.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Guitar
        private async void Sound44_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Guitar.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Harmonica
        private async void Sound45_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("harmonica.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Harp
        private async void Sound46_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("harp.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Piano
        private async void Sound47_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Grand Piano.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Triangle
        private async void Sound48_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("triangle.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Saxophone
        private async void Sound50_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("saxophone.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        // Trumpet
        private async void Sound51_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong1 = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Instrument");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("trumpet.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong1.SetSource(stream, file.ContentType);
            mysong1.Play();
        }

        #endregion

        // Instruments spell checks and clues
        #region
        // Banjo
        private void button72_Click(object sender, RoutedEventArgs e)
        {
            if (textBox38.Text.ToLower() == "banjo")
            {
                ppup5.IsOpen = true;
                textBox38.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox38.Text = String.Empty;
            }
        }

        private async void button73_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ O");
            await message.ShowAsync();
        }

        // Bass
        private void button74_Click(object sender, RoutedEventArgs e)
        {
            if (textBox39.Text.ToLower() == "bass")
            {
                ppup5.IsOpen = true;
                textBox39.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox39.Text = String.Empty;
            }
        }

        private async void button75_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _");
            await message.ShowAsync();
        }

        // Didgeridoo
        private void button76_Click(object sender, RoutedEventArgs e)
        {
            if (textBox40.Text.ToLower() == "didgeridoo")
            {
                ppup5.IsOpen = true;
                textBox40.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox40.Text = String.Empty;
            }
        }

        private async void button77_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ _ _ _ _ O O");
            await message.ShowAsync();
        }

        // Drums
        private void button78_Click(object sender, RoutedEventArgs e)
        {
            if (textBox42.Text.ToLower() == "drums")
            {
                ppup5.IsOpen = true;
                textBox42.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox42.Text = String.Empty;
            }
        }

        private async void button79_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ _");
            await message.ShowAsync();
        }

        // Flute
        private void button80_Click(object sender, RoutedEventArgs e)
        {
            if (textBox43.Text.ToLower() == "flute")
            {
                ppup5.IsOpen = true;
                textBox43.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox43.Text = String.Empty;
            }
        }

        private async void button81_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ E");
            await message.ShowAsync();
        }

        // Guitar
        private void button82_Click(object sender, RoutedEventArgs e)
        {
            if (textBox44.Text.ToLower() == "guitar")
            {
                ppup5.IsOpen = true;
                textBox44.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox44.Text = String.Empty;
            }
        }

        private async void button83_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ A _");
            await message.ShowAsync();
        }

        // Harmonica
        private void button84_Click(object sender, RoutedEventArgs e)
        {
            if (textBox45.Text.ToLower() == "harmonica")
            {
                ppup5.IsOpen = true;
                textBox45.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox45.Text = String.Empty;
            }
        }

        private async void button85_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("H _ _ _ _ _ _ _ _");
            await message.ShowAsync();
        }

        // Harp
        private void button86_Click(object sender, RoutedEventArgs e)
        {
            if (textBox47.Text.ToLower() == "harp")
            {
                ppup5.IsOpen = true;
                textBox47.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox47.Text = String.Empty;
            }
        }

        private async void button87_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _");
            await message.ShowAsync();
        }

        // Piano
        private void button88_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxx47.Text.ToLower() == "piano")
            {
                ppup5.IsOpen = true;
                textBoxx47.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBoxx47.Text = String.Empty;
            }
        }

        private async void button89_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ _");
            await message.ShowAsync();
        }

        // Triangle
        private void button90_Click(object sender, RoutedEventArgs e)
        {
            if (textBox49.Text.ToLower() == "triangle")
            {
                ppup5.IsOpen = true;
                textBox49.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox49.Text = String.Empty;
            }
        }

        private async void button91_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ N _ _ _");
            await message.ShowAsync();
        }

        // Saxophone
        private void button92_Click(object sender, RoutedEventArgs e)
        {
            if (textBox50.Text.ToLower() == "saxophone")
            {
                ppup5.IsOpen = true;
                textBox50.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox50.Text = String.Empty;
            }
        }

        private async void button93_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("_ _ _ _ P _ _ _ _");
            await message.ShowAsync();
        }

        // Trumpet
        private void button94_Click(object sender, RoutedEventArgs e)
        {
            if (textBox51.Text.ToLower() == "trumpet")
            {
                ppup5.IsOpen = true;
                textBox51.Text = String.Empty;
            }

            else
            {
                ppup6.IsOpen = true;
                textBox51.Text = String.Empty;
            }
        }

        private async void button95_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("T _ _ _ _ _ _");
            await message.ShowAsync();
        }
        #endregion

        // Back to Home Button & Sign out Button
        #region
        private void butto96_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WelcomePage));
        }

        private void button97_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        #endregion
    }
}
