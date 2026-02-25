using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Auth2;
using UI.Windows;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F6 RID: 1014
	[Token(Token = "0x20003F6")]
	public class ExistNickResolverWindow : BaseDialogWindow<ExistNickResolverWindow.ExistNickResolveWindowArgs>
	{
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000425")]
		public override string WindowId
		{
			[Token(Token = "0x60017CC")]
			[Address(RVA = "0x6987", Offset = "0x6987", VA = "0x6987", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x6988", Offset = "0x6988", VA = "0x6988", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x6989", Offset = "0x6989", VA = "0x6989", Slot = "27")]
		protected override void HandleDescription()
		{
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x698A", Offset = "0x698A", VA = "0x698A", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000426")]
		public RepeatedField<string> NickVariants
		{
			[Token(Token = "0x60017D0")]
			[Address(RVA = "0x698B", Offset = "0x698B", VA = "0x698B")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017D1")]
			[Address(RVA = "0x698C", Offset = "0x698C", VA = "0x698C")]
			set
			{
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x698D", Offset = "0x698D", VA = "0x698D")]
		private void HandleNickVariantsChanged()
		{
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x698E", Offset = "0x698E", VA = "0x698E")]
		private void HandleConfirmButtonOnClickEvent(string nick)
		{
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60017D4")]
		[Address(RVA = "0x698F", Offset = "0x698F", VA = "0x698F")]
		public static ExistNickResolverWindow Show(string sourceNick, RepeatedField<string> NickVariants, Action<string> resultCallback)
		{
			return null;
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x6990", Offset = "0x6990", VA = "0x6990")]
		public static ExistNickResolverWindow Show(string sourceNick, RepeatedField<string> NickVariants, Action<string> resultCallback, RegisterCmd.Types.Result result)
		{
			return null;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x6991", Offset = "0x6991", VA = "0x6991")]
		public ExistNickResolverWindow()
		{
		}

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/UserInfo/ExistNickResolverWindow";

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private NickVariantItemRow _itemRowPrefab;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[FieldOffset(Offset = "0x54")]
		private RepeatedField<string> _nickVariants;

		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4000CA4")]
		[FieldOffset(Offset = "0x58")]
		private List<NickVariantItemRow> _rows;

		// Token: 0x020003F7 RID: 1015
		[Token(Token = "0x20003F7")]
		public class ExistNickResolveWindowArgs : BaseDialogWindow<ExistNickResolverWindow.ExistNickResolveWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060017D7 RID: 6103 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017D7")]
			[Address(RVA = "0x6992", Offset = "0x6992", VA = "0x6992")]
			public ExistNickResolveWindowArgs(RegisterCmd.Types.Result registerResult)
			{
			}

			// Token: 0x060017D8 RID: 6104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017D8")]
			[Address(RVA = "0x6993", Offset = "0x6993", VA = "0x6993")]
			public ExistNickResolveWindowArgs()
			{
			}

			// Token: 0x060017D9 RID: 6105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017D9")]
			[Address(RVA = "0x6994", Offset = "0x6994", VA = "0x6994", Slot = "5")]
			public override void Dispose()
			{
			}

			// Token: 0x04000CA5 RID: 3237
			[Token(Token = "0x4000CA5")]
			[FieldOffset(Offset = "0x2C")]
			public string SourceNick;

			// Token: 0x04000CA6 RID: 3238
			[Token(Token = "0x4000CA6")]
			[FieldOffset(Offset = "0x30")]
			public RepeatedField<string> NickVariants;

			// Token: 0x04000CA7 RID: 3239
			[Token(Token = "0x4000CA7")]
			[FieldOffset(Offset = "0x34")]
			public Action<string> ResultCallback;
		}
	}
}
