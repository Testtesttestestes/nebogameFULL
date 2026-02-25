using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Gameplay.Discounts.Model;
using Gameplay.School.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using UI;
using UI.Elements.Buttons;
using UI.Elements.Counters;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Buildings.MagicTower.View
{
	// Token: 0x02000AAF RID: 2735
	[Token(Token = "0x2000AAF")]
	public class ClanSpellListElement : MonoBehaviourWithStates<ClanSpellListElement.State>, IDiscountTarget
	{
		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x0000CA50 File Offset: 0x0000AC50
		// (set) Token: 0x060041FE RID: 16894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D01")]
		public bool Selected
		{
			[Token(Token = "0x60041FD")]
			[Address(RVA = "0x90B1", Offset = "0x90B1", VA = "0x90B1")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041FE")]
			[Address(RVA = "0x90B2", Offset = "0x90B2", VA = "0x90B2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004200 RID: 16896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D02")]
		public SchoolSpellData Spell
		{
			[Token(Token = "0x60041FF")]
			[Address(RVA = "0x90B3", Offset = "0x90B3", VA = "0x90B3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004200")]
			[Address(RVA = "0x90B4", Offset = "0x90B4", VA = "0x90B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400019D RID: 413
		// (add) Token: 0x06004201 RID: 16897 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004202 RID: 16898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019D")]
		public event Action<ClanSpellListElement> SelectEvent
		{
			[Token(Token = "0x6004201")]
			[Address(RVA = "0x90B5", Offset = "0x90B5", VA = "0x90B5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004202")]
			[Address(RVA = "0x90B6", Offset = "0x90B6", VA = "0x90B6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400019E RID: 414
		// (add) Token: 0x06004203 RID: 16899 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004204 RID: 16900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019E")]
		public event Action<ClanSpellListElement> UseButtonClickedEvent
		{
			[Token(Token = "0x6004203")]
			[Address(RVA = "0x90B7", Offset = "0x90B7", VA = "0x90B7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004204")]
			[Address(RVA = "0x90B8", Offset = "0x90B8", VA = "0x90B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004205")]
		[Address(RVA = "0x90B9", Offset = "0x90B9", VA = "0x90B9")]
		private void Awake()
		{
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004206")]
		[Address(RVA = "0x90BA", Offset = "0x90BA", VA = "0x90BA")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004207")]
		[Address(RVA = "0x90BB", Offset = "0x90BB", VA = "0x90BB")]
		public void Init(SchoolSpellData spell)
		{
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004208")]
		[Address(RVA = "0x90BC", Offset = "0x90BC", VA = "0x90BC")]
		public void SelectSilent(bool select)
		{
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004209")]
		[Address(RVA = "0x90BD", Offset = "0x90BD", VA = "0x90BD")]
		private void ToggleSelect()
		{
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420A")]
		[Address(RVA = "0x90BE", Offset = "0x90BE", VA = "0x90BE")]
		private void UseButtonClickedEventHandler()
		{
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D03")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x600420B")]
			[Address(RVA = "0x90BF", Offset = "0x90BF", VA = "0x90BF", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420C")]
		[Address(RVA = "0x90C0", Offset = "0x90C0", VA = "0x90C0", Slot = "6")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420D")]
		[Address(RVA = "0x90C1", Offset = "0x90C1", VA = "0x90C1")]
		public ClanSpellListElement()
		{
		}

		// Token: 0x04002463 RID: 9315
		[Token(Token = "0x4002463")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _selectButton;

		// Token: 0x04002464 RID: 9316
		[Token(Token = "0x4002464")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImageLoader _spellGameRawImageLoader;

		// Token: 0x04002465 RID: 9317
		[Token(Token = "0x4002465")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x04002466 RID: 9318
		[Token(Token = "0x4002466")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LevelCounter _levelCounter;

		// Token: 0x04002467 RID: 9319
		[Token(Token = "0x4002467")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ParticleSystem _learningEffect;

		// Token: 0x04002468 RID: 9320
		[Token(Token = "0x4002468")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ButtonWithCost _costButton;

		// Token: 0x04002469 RID: 9321
		[Token(Token = "0x4002469")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ProgressBarWithTimer _progressBar;

		// Token: 0x0400246A RID: 9322
		[Token(Token = "0x400246A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _discountWidget;

		// Token: 0x02000AB0 RID: 2736
		[Token(Token = "0x2000AB0")]
		public enum State
		{
			// Token: 0x04002470 RID: 9328
			[Token(Token = "0x4002470")]
			UNKNOWN_STATE,
			// Token: 0x04002471 RID: 9329
			[Token(Token = "0x4002471")]
			IDLE,
			// Token: 0x04002472 RID: 9330
			[Token(Token = "0x4002472")]
			ACTIVE,
			// Token: 0x04002473 RID: 9331
			[Token(Token = "0x4002473")]
			NOT_LEARNED
		}
	}
}
