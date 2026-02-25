using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Core.Materials;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Inventory.View
{
	// Token: 0x0200065A RID: 1626
	[Token(Token = "0x200065A")]
	public class ArtikulView : AbstractDataRenderer<ArtikulData>, IPointerClickHandler, IEventSystemHandler, IToolTipDataProvider, IGrayscalable
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000078D8 File Offset: 0x00005AD8
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000773")]
		public int? StackSizeExternal
		{
			[Token(Token = "0x6002778")]
			[Address(RVA = "0x78A9", Offset = "0x78A9", VA = "0x78A9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002779")]
			[Address(RVA = "0x78AA", Offset = "0x78AA", VA = "0x78AA")]
			set
			{
			}
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x78AB", Offset = "0x78AB", VA = "0x78AB", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x000078F0 File Offset: 0x00005AF0
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000774")]
		public bool Interactable
		{
			[Token(Token = "0x600277B")]
			[Address(RVA = "0x78AC", Offset = "0x78AC", VA = "0x78AC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600277C")]
			[Address(RVA = "0x78AD", Offset = "0x78AD", VA = "0x78AD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277D")]
		[Address(RVA = "0x78AE", Offset = "0x78AE", VA = "0x78AE", Slot = "23")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x78AF", Offset = "0x78AF", VA = "0x78AF", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x78B0", Offset = "0x78B0", VA = "0x78B0")]
		private void RenderStackSize()
		{
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x78B1", Offset = "0x78B1", VA = "0x78B1", Slot = "5")]
		protected override void CommitProperties()
		{
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002781")]
		[Address(RVA = "0x78B2", Offset = "0x78B2", VA = "0x78B2", Slot = "24")]
		public virtual BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x78B3", Offset = "0x78B3", VA = "0x78B3", Slot = "22")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x78B4", Offset = "0x78B4", VA = "0x78B4")]
		public ArtikulView()
		{
		}

		// Token: 0x040015A4 RID: 5540
		[Token(Token = "0x40015A4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameRawImage _icon;

		// Token: 0x040015A5 RID: 5541
		[Token(Token = "0x40015A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameRawImage _qualityBg;

		// Token: 0x040015A6 RID: 5542
		[Token(Token = "0x40015A6")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _stackLabel;

		// Token: 0x040015A7 RID: 5543
		[Token(Token = "0x40015A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _stackOwner;

		// Token: 0x040015A8 RID: 5544
		[Token(Token = "0x40015A8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x040015A9 RID: 5545
		[Token(Token = "0x40015A9")]
		[FieldOffset(Offset = "0x38")]
		private bool _stackSizeChanged;

		// Token: 0x040015AA RID: 5546
		[Token(Token = "0x40015AA")]
		[FieldOffset(Offset = "0x3C")]
		private int? _stackSizeExternal;
	}
}
