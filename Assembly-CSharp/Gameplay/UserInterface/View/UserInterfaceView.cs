using System;
using Gameplay.UserInterface.Control;
using Gameplay.UserInterface.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	public class UserInterfaceView : MonoBehaviour
	{
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D1")]
		public ShowHideUIElementByRestrictions.UIElementsByRestrictions UIElementsByRestrictions
		{
			[Token(Token = "0x6001696")]
			[Address(RVA = "0x6857", Offset = "0x6857", VA = "0x6857")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D2")]
		public WorldIndexButtonsView WorldIndexButtonsView
		{
			[Token(Token = "0x6001697")]
			[Address(RVA = "0x6858", Offset = "0x6858", VA = "0x6858")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D3")]
		public UserInterfaceButtonsView UserInterfaceButtonsView
		{
			[Token(Token = "0x6001698")]
			[Address(RVA = "0x6859", Offset = "0x6859", VA = "0x6859")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001699")]
		[Address(RVA = "0x685A", Offset = "0x685A", VA = "0x685A")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x685B", Offset = "0x685B", VA = "0x685B")]
		private void Awake()
		{
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x685C", Offset = "0x685C", VA = "0x685C")]
		private void InitMVC(UserInterfaceView view)
		{
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x685D", Offset = "0x685D", VA = "0x685D")]
		public UserInterfaceView()
		{
		}

		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private LocationOwnerIndexView _locationOwnerIndexView;

		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private UserInterfaceButtonsView _userInterfaceButtonsView;

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WorldIndexButtonsView _worldIndexButtonsView;

		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ShowHideUIElementByRestrictions.UIElementsByRestrictions _uiElements;

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x20")]
		private UserInterfaceModel _model;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x24")]
		private UserInterfaceController _controller;

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x28")]
		private UserInterfaceViewMediator _mediator;
	}
}
