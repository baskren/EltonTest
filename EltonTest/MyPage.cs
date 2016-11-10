// /*******************************************************************
//  *
//  * MyPage.cs copyright 2016 ben, 42nd Parallel - ALL RIGHTS RESERVED.
//  *
//  *******************************************************************/
using System;

using Xamarin.Forms;

namespace EltonTest
{
	public class MyPage : ContentPage
	{
		public MyPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			var modal = new Forms9Patch.ModalPopup
			{
				Content = new Forms9Patch.StackLayout
				{
					Children = {
										new Xamarin.Forms.Label {
											Text = "Hello Modal popup!",
											TextColor = Color.Black}
									},
					BackgroundColor = Color.FromRgb(100, 100, 100),
					Padding = 20,
				},
				OutlineRadius = 4,
				OutlineWidth = 1,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Aqua,
				HasShadow = true,
				HeightRequest = 200,
				WidthRequest = 200,
			};
			modal.BindingContext = this;
			modal.IsVisible = true;
		}
	}
}

