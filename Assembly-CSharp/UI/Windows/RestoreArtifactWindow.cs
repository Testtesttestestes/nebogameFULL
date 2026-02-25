using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200029D RID: 669
	[Token(Token = "0x200029D")]
	public class RestoreArtifactWindow : BaseDialogWindow<RestoreArtifactWindow.RestoreArtifactWindowArgs>
	{
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000234")]
		public override string WindowId
		{
			[Token(Token = "0x6000FAE")]
			[Address(RVA = "0x61D7", Offset = "0x61D7", VA = "0x61D7", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x61D8", Offset = "0x61D8", VA = "0x61D8", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FB0")]
		[Address(RVA = "0x61D9", Offset = "0x61D9", VA = "0x61D9")]
		public static RestoreArtifactWindow Show(ArtifactData artifactData)
		{
			return null;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x61DA", Offset = "0x61DA", VA = "0x61DA")]
		public RestoreArtifactWindow()
		{
		}

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/RestoreArtifactWindow";

		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x0200029E RID: 670
		[Token(Token = "0x200029E")]
		public class RestoreArtifactWindowArgs : BaseDialogWindow<RestoreArtifactWindow.RestoreArtifactWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000235 RID: 565
			// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000235")]
			public ArtifactData Artifact
			{
				[Token(Token = "0x6000FB2")]
				[Address(RVA = "0x61DB", Offset = "0x61DB", VA = "0x61DB")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000FB3")]
				[Address(RVA = "0x61DC", Offset = "0x61DC", VA = "0x61DC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000FB4 RID: 4020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FB4")]
			[Address(RVA = "0x61DD", Offset = "0x61DD", VA = "0x61DD")]
			public RestoreArtifactWindowArgs(ArtifactData artifact)
			{
			}

			// Token: 0x06000FB5 RID: 4021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FB5")]
			[Address(RVA = "0x61DE", Offset = "0x61DE", VA = "0x61DE", Slot = "6")]
			protected virtual void InitInstance()
			{
			}
		}
	}
}
