﻿#pragma checksum "D:\risuscitò\risu_win\risu_win\risu_win\Ricerca_pivot.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8680B3135FD5C7AA7DAA3610D5F25BBB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.34209
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace risu_win {
    
    
    public partial class Ricerca_pivot : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock ricerca_per_titolo;
        
        internal System.Windows.Controls.TextBox ricerca_veloce_text;
        
        internal System.Windows.Controls.Button Pulisci_ricercaveloce;
        
        internal System.Windows.Controls.ListBox Return_ricercaveloce;
        
        internal System.Windows.Controls.TextBlock ricerca_nel_testo;
        
        internal System.Windows.Controls.TextBox ricerca_avanzata_text;
        
        internal System.Windows.Controls.Button Pulisci_avanzata;
        
        internal System.Windows.Controls.ListBox Return_avanzata;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Home_bmenu;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Indici_bmenu;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Liste_bmenu;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Preferiti_bmenu;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem Impostazioni_bmenu;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem Changelog_bmenu;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem Ringrazia_bmenu;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/risu_win;component/Ricerca_pivot.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ricerca_per_titolo = ((System.Windows.Controls.TextBlock)(this.FindName("ricerca_per_titolo")));
            this.ricerca_veloce_text = ((System.Windows.Controls.TextBox)(this.FindName("ricerca_veloce_text")));
            this.Pulisci_ricercaveloce = ((System.Windows.Controls.Button)(this.FindName("Pulisci_ricercaveloce")));
            this.Return_ricercaveloce = ((System.Windows.Controls.ListBox)(this.FindName("Return_ricercaveloce")));
            this.ricerca_nel_testo = ((System.Windows.Controls.TextBlock)(this.FindName("ricerca_nel_testo")));
            this.ricerca_avanzata_text = ((System.Windows.Controls.TextBox)(this.FindName("ricerca_avanzata_text")));
            this.Pulisci_avanzata = ((System.Windows.Controls.Button)(this.FindName("Pulisci_avanzata")));
            this.Return_avanzata = ((System.Windows.Controls.ListBox)(this.FindName("Return_avanzata")));
            this.Home_bmenu = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Home_bmenu")));
            this.Indici_bmenu = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Indici_bmenu")));
            this.Liste_bmenu = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Liste_bmenu")));
            this.Preferiti_bmenu = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Preferiti_bmenu")));
            this.Impostazioni_bmenu = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("Impostazioni_bmenu")));
            this.Changelog_bmenu = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("Changelog_bmenu")));
            this.Ringrazia_bmenu = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("Ringrazia_bmenu")));
        }
    }
}
