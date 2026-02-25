using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Bag
{
	// Token: 0x02000699 RID: 1689
	[Token(Token = "0x2000699")]
	public class InventoryBagSlotView : MonoBehaviour, IInventoryBagSlotView
	{
		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x00007B00 File Offset: 0x00005D00
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B9")]
		public int SlotId
		{
			[Token(Token = "0x60028CB")]
			[Address(RVA = "0x79E5", Offset = "0x79E5", VA = "0x79E5", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60028CC")]
			[Address(RVA = "0x79E6", Offset = "0x79E6", VA = "0x79E6", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007BA")]
		public ArtifactView ArtifactView
		{
			[Token(Token = "0x60028CD")]
			[Address(RVA = "0x79E7", Offset = "0x79E7", VA = "0x79E7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BB")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x60028CE")]
			[Address(RVA = "0x79E8", Offset = "0x79E8", VA = "0x79E8", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028CF")]
			[Address(RVA = "0x79E9", Offset = "0x79E9", VA = "0x79E9", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D0")]
		[Address(RVA = "0x79EA", Offset = "0x79EA", VA = "0x79EA")]
		public InventoryBagSlotView()
		{
		}

		// Token: 0x04001685 RID: 5765
		[Token(Token = "0x4001685")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04001686 RID: 5766
		[Token(Token = "0x4001686")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ArtifactView _artifactView;
	}
}
