﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Windows;
using Microsoft.Common.Core.Services;
using Microsoft.R.Components.ConnectionManager.ViewModel;

namespace Microsoft.R.Components.ConnectionManager.Implementation.ViewModel {
    public class ConnectionStatusBarViewModel : ConnectionStatusBaseViewModel, IConnectionStatusBarViewModel {
        private string _selectedConnection;

        public ConnectionStatusBarViewModel(IServiceContainer services): 
            base(services) {
            SelectedConnection = ConnectionManager.ActiveConnection?.Name;
        }

        public string SelectedConnection {
            get => _selectedConnection;
            set => SetProperty(ref _selectedConnection, value);
        }

        public void ShowContextMenu(Point point) 
            => Services.ShowContextMenu(ConnectionManagerCommandIds.ContextMenu, (int)point.X, (int)point.Y);

        protected override void UpdateConnections()
            => SelectedConnection = ConnectionManager.ActiveConnection?.Name;
    }
}
