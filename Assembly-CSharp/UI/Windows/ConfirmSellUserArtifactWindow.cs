using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200028E RID: 654
	[Token(Token = "0x200028E")]
	public class ConfirmSellUserArtifactWindow : BaseDialogWindow<ConfirmSellUserArtifactWindow.SellUserArtifactWindowArgs>
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000221")]
		public override string WindowId
		{
			[Token(Token = "0x6000F62")]
			[Address(RVA = "0x618D", Offset = "0x618D", VA = "0x618D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x618E", Offset = "0x618E", VA = "0x618E", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x618F", Offset = "0x618F", VA = "0x618F")]
		public static ConfirmSellUserArtifactWindow Show(UserData user, Action<ArtifactData[]> resultCallback, params ArtifactData[] artifacts)
		{
			return null;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x6190", Offset = "0x6190", VA = "0x6190")]
		public ConfirmSellUserArtifactWindow()
		{
		}

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ConfirmSellUserArtifactWindow";

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x0200028F RID: 655
		[Token(Token = "0x200028F")]
		public class SellUserArtifactWindowArgs : BaseDialogWindow<ConfirmSellUserArtifactWindow.SellUserArtifactWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000F66 RID: 3942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F66")]
			[Address(RVA = "0x6191", Offset = "0x6191", VA = "0x6191")]
			public SellUserArtifactWindowArgs(ArtifactData[] artifacts, UserData user)
			{
			}

			// Token: 0x06000F67 RID: 3943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F67")]
			[Address(RVA = "0x6192", Offset = "0x6192", VA = "0x6192")]
			private void InitInstance()
			{
			}

			// Token: 0x06000F68 RID: 3944 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F68")]
			[Address(RVA = "0x6193", Offset = "0x6193", VA = "0x6193", Slot = "6")]
			protected virtual void DefineTitle()
			{
			}

			// Token: 0x06000F69 RID: 3945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F69")]
			[Address(RVA = "0x6194", Offset = "0x6194", VA = "0x6194", Slot = "7")]
			protected virtual void DetermineNonZeroDescription()
			{
			}

			// Token: 0x17000222 RID: 546
			// (get) Token: 0x06000F6A RID: 3946 RVA: 0x000044A0 File Offset: 0x000026A0
			// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000222")]
			public int MaxArtifactCountForDisplay
			{
				[Token(Token = "0x6000F6A")]
				[Address(RVA = "0x6195", Offset = "0x6195", VA = "0x6195")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000F6B")]
				[Address(RVA = "0x6196", Offset = "0x6196", VA = "0x6196")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000223 RID: 547
			// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000223")]
			public uint[] SlotIds
			{
				[Token(Token = "0x6000F6C")]
				[Address(RVA = "0x6197", Offset = "0x6197", VA = "0x6197")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000F6D")]
				[Address(RVA = "0x6198", Offset = "0x6198", VA = "0x6198")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000224 RID: 548
			// (get) Token: 0x06000F6E RID: 3950 RVA: 0x000044B8 File Offset: 0x000026B8
			// (set) Token: 0x06000F6F RID: 3951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000224")]
			public bool IsContainsStackable
			{
				[Token(Token = "0x6000F6E")]
				[Address(RVA = "0x6199", Offset = "0x6199", VA = "0x6199")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000F6F")]
				[Address(RVA = "0x619A", Offset = "0x619A", VA = "0x619A")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000225 RID: 549
			// (get) Token: 0x06000F70 RID: 3952 RVA: 0x000044D0 File Offset: 0x000026D0
			// (set) Token: 0x06000F71 RID: 3953 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000225")]
			public bool IsContainsBroken
			{
				[Token(Token = "0x6000F70")]
				[Address(RVA = "0x619B", Offset = "0x619B", VA = "0x619B")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000F71")]
				[Address(RVA = "0x619C", Offset = "0x619C", VA = "0x619C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000226 RID: 550
			// (get) Token: 0x06000F72 RID: 3954 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000F73 RID: 3955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000226")]
			public ResourceSet Price
			{
				[Token(Token = "0x6000F72")]
				[Address(RVA = "0x619D", Offset = "0x619D", VA = "0x619D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000F73")]
				[Address(RVA = "0x619E", Offset = "0x619E", VA = "0x619E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000227 RID: 551
			// (get) Token: 0x06000F74 RID: 3956 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000227")]
			public ResourceSet TradePrice
			{
				[Token(Token = "0x6000F74")]
				[Address(RVA = "0x619F", Offset = "0x619F", VA = "0x619F")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000F75")]
				[Address(RVA = "0x61A0", Offset = "0x61A0", VA = "0x61A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x040007D5 RID: 2005
			[Token(Token = "0x40007D5")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;

			// Token: 0x040007D6 RID: 2006
			[Token(Token = "0x40007D6")]
			[FieldOffset(Offset = "0x30")]
			public UserData User;
		}
	}
}
