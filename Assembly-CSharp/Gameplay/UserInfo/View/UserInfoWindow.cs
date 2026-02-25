using System;
using System.Collections.Generic;
using Core.Data;
using Core.MVC.Interfaces;
using Gameplay.UserInfo.Control;
using Gameplay.UserInfo.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000405 RID: 1029
	[Token(Token = "0x2000405")]
	public class UserInfoWindow : ClosableBaseWindow<UserInfoWindow.UserInfoWindowArgs>
	{
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000448")]
		public override string WindowId
		{
			[Token(Token = "0x6001834")]
			[Address(RVA = "0x69E8", Offset = "0x69E8", VA = "0x69E8", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001835")]
		[Address(RVA = "0x69E9", Offset = "0x69E9", VA = "0x69E9", Slot = "22")]
		protected override void OnShow(UserInfoWindow.UserInfoWindowArgs args)
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x69EA", Offset = "0x69EA", VA = "0x69EA", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x69EB", Offset = "0x69EB", VA = "0x69EB")]
		private void HandleUserViewOnReadyEvent()
		{
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x69EC", Offset = "0x69EC", VA = "0x69EC")]
		private void ShowDependentView()
		{
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x69ED", Offset = "0x69ED", VA = "0x69ED")]
		private void CreateMVC(UserData user)
		{
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x69EE", Offset = "0x69EE", VA = "0x69EE")]
		public UserInfoWindow()
		{
		}

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/UserInfo/UserInfoWindow";

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private UserInfoView _userInfoView;

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		[FieldOffset(Offset = "0x40")]
		private UserInfoEvents _events;

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x44")]
		private UserInfoController _controller;

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x48")]
		private UserInfoModel _model;

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x4C")]
		private readonly List<IViewMediator> _mediators;

		// Token: 0x02000406 RID: 1030
		[Token(Token = "0x2000406")]
		public enum DependentView
		{
			// Token: 0x04000CF3 RID: 3315
			[Token(Token = "0x4000CF3")]
			NOTHING,
			// Token: 0x04000CF4 RID: 3316
			[Token(Token = "0x4000CF4")]
			EDIT_WINDOW
		}

		// Token: 0x02000407 RID: 1031
		[Token(Token = "0x2000407")]
		public class UserInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600183B RID: 6203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600183B")]
			[Address(RVA = "0x69EF", Offset = "0x69EF", VA = "0x69EF")]
			public UserInfoWindowArgs(UserData user)
			{
			}

			// Token: 0x04000CF5 RID: 3317
			[Token(Token = "0x4000CF5")]
			[FieldOffset(Offset = "0x18")]
			public readonly UserData User;

			// Token: 0x04000CF6 RID: 3318
			[Token(Token = "0x4000CF6")]
			[FieldOffset(Offset = "0x1C")]
			public UserInfoWindow.DependentView Dependent;
		}
	}
}
