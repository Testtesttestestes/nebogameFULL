using System;
using System.Collections.Generic;
using AssetContent;
using Gameplay.Discounts.Model;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Elements.Counters;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.Buildings
{
	// Token: 0x0200024A RID: 586
	[Token(Token = "0x200024A")]
	public class SpellItem : SelectedGenericListElement<SpellItemArgs>, IDiscountTarget
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EC")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0x60D7", Offset = "0x60D7", VA = "0x60D7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00004200 File Offset: 0x00002400
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001ED")]
		public override bool Selected
		{
			[Token(Token = "0x6000E4F")]
			[Address(RVA = "0x60D8", Offset = "0x60D8", VA = "0x60D8", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x60D9", Offset = "0x60D9", VA = "0x60D9", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x60DA", Offset = "0x60DA", VA = "0x60DA", Slot = "4")]
		protected override void OnInit(SpellItemArgs args)
		{
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x60DB", Offset = "0x60DB", VA = "0x60DB")]
		public void Close()
		{
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EE")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x60DC", Offset = "0x60DC", VA = "0x60DC", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x60DD", Offset = "0x60DD", VA = "0x60DD", Slot = "10")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x60DE", Offset = "0x60DE", VA = "0x60DE")]
		public SpellItem()
		{
		}

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameImage _spellGameImage;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LevelCounter _levelCounter;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ParticleSystem _learningEffect;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _discountWidget;

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x34")]
		private IGuideTarget _guideTarget;
	}
}
