using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Price;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000ACC RID: 2764
	[Token(Token = "0x2000ACC")]
	public class TruceStatusView : MonoBehaviourWithStates<TruceStatusView.State>
	{
		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1C")]
		public TextMeshProUGUI StatusTitle
		{
			[Token(Token = "0x6004291")]
			[Address(RVA = "0x9145", Offset = "0x9145", VA = "0x9145")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1D")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6004292")]
			[Address(RVA = "0x9146", Offset = "0x9146", VA = "0x9146")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1E")]
		public Button ShieldButton
		{
			[Token(Token = "0x6004293")]
			[Address(RVA = "0x9147", Offset = "0x9147", VA = "0x9147")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1F")]
		public Button WarButton
		{
			[Token(Token = "0x6004294")]
			[Address(RVA = "0x9148", Offset = "0x9148", VA = "0x9148")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D20")]
		public RequirementsView RequirementsView
		{
			[Token(Token = "0x6004295")]
			[Address(RVA = "0x9149", Offset = "0x9149", VA = "0x9149")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D21")]
		public Price Price
		{
			[Token(Token = "0x6004296")]
			[Address(RVA = "0x914A", Offset = "0x914A", VA = "0x914A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004297")]
		[Address(RVA = "0x914B", Offset = "0x914B", VA = "0x914B")]
		private void Awake()
		{
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004298")]
		[Address(RVA = "0x914C", Offset = "0x914C", VA = "0x914C")]
		public void PrepareView()
		{
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004299")]
		[Address(RVA = "0x914D", Offset = "0x914D", VA = "0x914D")]
		public void SetHonor(int honor)
		{
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429A")]
		[Address(RVA = "0x914E", Offset = "0x914E", VA = "0x914E")]
		public void SetStatusDescriptionKey(string localizationKey)
		{
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429B")]
		[Address(RVA = "0x914F", Offset = "0x914F", VA = "0x914F")]
		public void SetStatusAnnotationKey(string localizationKey)
		{
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429C")]
		[Address(RVA = "0x9150", Offset = "0x9150", VA = "0x9150")]
		public void SetStatusAnnotationText(string text)
		{
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429D")]
		[Address(RVA = "0x9151", Offset = "0x9151", VA = "0x9151")]
		public void SetBacktime(BackTime backtime)
		{
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429E")]
		[Address(RVA = "0x9152", Offset = "0x9152", VA = "0x9152", Slot = "4")]
		protected override void HandleCurrentStateChanged(TruceStatusView.State fromState, TruceStatusView.State toState)
		{
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429F")]
		[Address(RVA = "0x9153", Offset = "0x9153", VA = "0x9153")]
		public TruceStatusView()
		{
		}

		// Token: 0x040024B8 RID: 9400
		[Token(Token = "0x40024B8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _statusTitle;

		// Token: 0x040024B9 RID: 9401
		[Token(Token = "0x40024B9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _statusDescription;

		// Token: 0x040024BA RID: 9402
		[Token(Token = "0x40024BA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040024BB RID: 9403
		[Token(Token = "0x40024BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _statusAnnotation;

		// Token: 0x040024BC RID: 9404
		[Token(Token = "0x40024BC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _shieldButton;

		// Token: 0x040024BD RID: 9405
		[Token(Token = "0x40024BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _warButton;

		// Token: 0x040024BE RID: 9406
		[Token(Token = "0x40024BE")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RequirementsView _requirements;

		// Token: 0x040024BF RID: 9407
		[Token(Token = "0x40024BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040024C0 RID: 9408
		[Token(Token = "0x40024C0")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Price _price;

		// Token: 0x040024C1 RID: 9409
		[Token(Token = "0x40024C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _honor;

		// Token: 0x040024C2 RID: 9410
		[Token(Token = "0x40024C2")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameRawImage _honorIcon;

		// Token: 0x040024C3 RID: 9411
		[Token(Token = "0x40024C3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _backtimeGroup;

		// Token: 0x02000ACD RID: 2765
		[Token(Token = "0x2000ACD")]
		public enum State
		{
			// Token: 0x040024C5 RID: 9413
			[Token(Token = "0x40024C5")]
			UNKNOWN_STATE,
			// Token: 0x040024C6 RID: 9414
			[Token(Token = "0x40024C6")]
			ALL_ENABLED,
			// Token: 0x040024C7 RID: 9415
			[Token(Token = "0x40024C7")]
			ALL_DISABLED,
			// Token: 0x040024C8 RID: 9416
			[Token(Token = "0x40024C8")]
			BASE_INFO,
			// Token: 0x040024C9 RID: 9417
			[Token(Token = "0x40024C9")]
			COMBAT
		}
	}
}
