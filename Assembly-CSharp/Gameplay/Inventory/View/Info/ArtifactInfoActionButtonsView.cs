using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Inventory;
using UI.Scroll;
using UnityEngine;

namespace Gameplay.Inventory.View.Info
{
	// Token: 0x02000666 RID: 1638
	[Token(Token = "0x2000666")]
	public class ArtifactInfoActionButtonsView : MonoBehaviour
	{
		// Token: 0x14000154 RID: 340
		// (add) Token: 0x060027CB RID: 10187 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060027CC RID: 10188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000154")]
		public static event Action<ArtikulMenuActionDic.Types.Actions> ActionHandledEvent
		{
			[Token(Token = "0x60027CB")]
			[Address(RVA = "0x78F1", Offset = "0x78F1", VA = "0x78F1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60027CC")]
			[Address(RVA = "0x78F2", Offset = "0x78F2", VA = "0x78F2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060027CE RID: 10190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078A")]
		public ArtifactView ArtifactView
		{
			[Token(Token = "0x60027CD")]
			[Address(RVA = "0x78F3", Offset = "0x78F3", VA = "0x78F3")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027CE")]
			[Address(RVA = "0x78F4", Offset = "0x78F4", VA = "0x78F4")]
			set
			{
			}
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x78F5", Offset = "0x78F5", VA = "0x78F5")]
		private void OnButtonClickEvent(ArtifactContextMenuElement element)
		{
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D0")]
		[Address(RVA = "0x78F6", Offset = "0x78F6", VA = "0x78F6")]
		private void OnDestroy()
		{
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D1")]
		[Address(RVA = "0x78F7", Offset = "0x78F7", VA = "0x78F7")]
		public ArtifactInfoActionButtonsView()
		{
		}

		// Token: 0x040015CA RID: 5578
		[Token(Token = "0x40015CA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ArtifactContextMenuElement _buttonPrefab;

		// Token: 0x040015CB RID: 5579
		[Token(Token = "0x40015CB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040015CC RID: 5580
		[Token(Token = "0x40015CC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollWithButtons _scrollWithButtons;

		// Token: 0x040015CE RID: 5582
		[Token(Token = "0x40015CE")]
		[FieldOffset(Offset = "0x1C")]
		private List<ArtifactContextMenuElement> _buttons;

		// Token: 0x040015CF RID: 5583
		[Token(Token = "0x40015CF")]
		[FieldOffset(Offset = "0x20")]
		private ArtifactView _artifactView;
	}
}
