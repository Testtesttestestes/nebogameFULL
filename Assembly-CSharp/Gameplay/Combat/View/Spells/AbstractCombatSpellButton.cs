using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Price;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x0200093E RID: 2366
	[Token(Token = "0x200093E")]
	public abstract class AbstractCombatSpellButton<T> : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IToolTipDataProvider, IDisposable where T : CombatSpellData
	{
		// Token: 0x1400017C RID: 380
		// (add) Token: 0x060037E0 RID: 14304 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060037E1 RID: 14305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400017C")]
		public event Action<T> OnClickEvent
		{
			[Token(Token = "0x60037E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60037E1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037E2")]
		public void DisposeEvents()
		{
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037E3")]
		public virtual void Dispose()
		{
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037E4")]
		private void OnDestroy()
		{
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037E5")]
		protected void Start()
		{
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x060037E6 RID: 14310 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060037E7 RID: 14311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B0A")]
		public Component MaskOnTop
		{
			[Token(Token = "0x60037E6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037E7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x060037E8 RID: 14312 RVA: 0x0000B370 File Offset: 0x00009570
		// (set) Token: 0x060037E9 RID: 14313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B0B")]
		public bool Selected
		{
			[Token(Token = "0x60037E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037E9")]
			set
			{
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x060037EA RID: 14314 RVA: 0x0000B388 File Offset: 0x00009588
		// (set) Token: 0x060037EB RID: 14315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B0C")]
		public bool Enabled
		{
			[Token(Token = "0x60037EA")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037EB")]
			set
			{
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060037ED RID: 14317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B0D")]
		public T Data
		{
			[Token(Token = "0x60037EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60037ED")]
			set
			{
			}
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037EE")]
		protected virtual void HandleDataChanged()
		{
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037EF")]
		protected virtual void DisplayPrice()
		{
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60037F0")]
		protected virtual PriceItemRenderer CreateManaPrice()
		{
			return null;
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60037F1")]
		protected virtual PriceItemRenderer InstantiateManaPrice(long value)
		{
			return null;
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F2")]
		protected virtual void ValidateManaPrice()
		{
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F3")]
		protected virtual void HandleSelectChanged()
		{
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F4")]
		protected virtual void HandleEnabledChanged()
		{
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F5")]
		public void UpdateUserBalanceChanged()
		{
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F6")]
		public void UpdateApplied()
		{
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F7")]
		public void UpdateStrobe()
		{
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F8")]
		public void UpdateEnabled()
		{
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F9")]
		public void UpdateSkills()
		{
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FA")]
		public void UpdateCooldown()
		{
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FB")]
		public void UpdateSelected()
		{
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FC")]
		public virtual void UpdateCount()
		{
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FD")]
		private void HideBacklightImage()
		{
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FE")]
		protected virtual void LoadImage()
		{
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FF")]
		private void ResetPrices()
		{
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003800")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003801")]
		public virtual BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003802")]
		protected AbstractCombatSpellButton()
		{
		}

		// Token: 0x04001EE9 RID: 7913
		[Token(Token = "0x4001EE9")]
		public const float APPLY_TWEEN_DURATION = 0.3f;

		// Token: 0x04001EEA RID: 7914
		[Token(Token = "0x4001EEA")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameObject _workStateOwner;

		// Token: 0x04001EEB RID: 7915
		[Token(Token = "0x4001EEB")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameObject _noDataStateOwner;

		// Token: 0x04001EEC RID: 7916
		[Token(Token = "0x4001EEC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x04001EED RID: 7917
		[Token(Token = "0x4001EED")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Image _backlightImage;

		// Token: 0x04001EEE RID: 7918
		[Token(Token = "0x4001EEE")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameRawImage _image;

		// Token: 0x04001EEF RID: 7919
		[Token(Token = "0x4001EEF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform _cooldownView;

		// Token: 0x04001EF0 RID: 7920
		[Token(Token = "0x4001EF0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TextMeshProUGUI _cooldownField;

		// Token: 0x04001EF1 RID: 7921
		[Token(Token = "0x4001EF1")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Transform _priceBar;

		// Token: 0x04001EF2 RID: 7922
		[Token(Token = "0x4001EF2")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Transform _priceInManaBar;

		// Token: 0x04001EF3 RID: 7923
		[Token(Token = "0x4001EF3")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected PriceItemRenderer _priceItemRendererPrefab;

		// Token: 0x04001EF4 RID: 7924
		[Token(Token = "0x4001EF4")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected PriceItemRenderer _priceInManaItemRendererPrefab;

		// Token: 0x04001EF5 RID: 7925
		[Token(Token = "0x4001EF5")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04001EF8 RID: 7928
		[Token(Token = "0x4001EF8")]
		[FieldOffset(Offset = "0x0")]
		private bool _selected;

		// Token: 0x04001EF9 RID: 7929
		[Token(Token = "0x4001EF9")]
		[FieldOffset(Offset = "0x0")]
		private bool _enabled;

		// Token: 0x04001EFA RID: 7930
		[Token(Token = "0x4001EFA")]
		[FieldOffset(Offset = "0x0")]
		private T _data;

		// Token: 0x04001EFB RID: 7931
		[Token(Token = "0x4001EFB")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<Protocol.Consts.Resources, PriceItemRenderer> _pricesViews;

		// Token: 0x04001EFC RID: 7932
		[Token(Token = "0x4001EFC")]
		[FieldOffset(Offset = "0x0")]
		private PriceItemRenderer _manaPriceRender;

		// Token: 0x04001EFD RID: 7933
		[Token(Token = "0x4001EFD")]
		[FieldOffset(Offset = "0x0")]
		private bool _backligthIsTweening;
	}
}
