using System;
using Gameplay.UserInfo.Control;
using Gameplay.UserInfo.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	public class UserInfoEditWindow : ClosableBaseWindow<UserInfoEditWindow.UserInfoEditWindowArgs>
	{
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000434")]
		public override string WindowId
		{
			[Token(Token = "0x600181B")]
			[Address(RVA = "0x69CF", Offset = "0x69CF", VA = "0x69CF", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x69D0", Offset = "0x69D0", VA = "0x69D0", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181D")]
		[Address(RVA = "0x69D1", Offset = "0x69D1", VA = "0x69D1", Slot = "22")]
		protected override void OnShow(UserInfoEditWindow.UserInfoEditWindowArgs args)
		{
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181E")]
		[Address(RVA = "0x69D2", Offset = "0x69D2", VA = "0x69D2")]
		public UserInfoEditWindow()
		{
		}

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/UserInfo/UserInfoEditWindow";

		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CultGenderNickSettingsView _view;

		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		[FieldOffset(Offset = "0x40")]
		private UserInfoEditViewMediator _mediator;

		// Token: 0x02000402 RID: 1026
		[Token(Token = "0x2000402")]
		public class UserInfoEditWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600181F RID: 6175 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600181F")]
			[Address(RVA = "0x69D3", Offset = "0x69D3", VA = "0x69D3")]
			public UserInfoEditWindowArgs(UserInfoModel model, UserInfoController controller)
			{
			}

			// Token: 0x04000CD3 RID: 3283
			[Token(Token = "0x4000CD3")]
			[FieldOffset(Offset = "0x18")]
			public readonly UserInfoModel Model;

			// Token: 0x04000CD4 RID: 3284
			[Token(Token = "0x4000CD4")]
			[FieldOffset(Offset = "0x1C")]
			public readonly UserInfoController Controller;
		}
	}
}
