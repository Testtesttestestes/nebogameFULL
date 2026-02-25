using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UI.Price;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexRating.View.VoteRewardsTab
{
	// Token: 0x02000386 RID: 902
	[Token(Token = "0x2000386")]
	public class GiftListElement : MonoBehaviourWithStates<GiftListElement.State>
	{
		// Token: 0x1400010A RID: 266
		// (add) Token: 0x06001506 RID: 5382 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001507 RID: 5383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400010A")]
		public event Action<GiftListElement> GiftListElementClickedEvent
		{
			[Token(Token = "0x6001506")]
			[Address(RVA = "0x66C8", Offset = "0x66C8", VA = "0x66C8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001507")]
			[Address(RVA = "0x66C9", Offset = "0x66C9", VA = "0x66C9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x00005190 File Offset: 0x00003390
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000374")]
		public uint SetId
		{
			[Token(Token = "0x6001508")]
			[Address(RVA = "0x66CA", Offset = "0x66CA", VA = "0x66CA")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001509")]
			[Address(RVA = "0x66CB", Offset = "0x66CB", VA = "0x66CB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000375 RID: 885
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000375")]
		public bool Assigned
		{
			[Token(Token = "0x600150A")]
			[Address(RVA = "0x66CC", Offset = "0x66CC", VA = "0x66CC")]
			set
			{
			}
		}

		// Token: 0x17000376 RID: 886
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000376")]
		public bool Selected
		{
			[Token(Token = "0x600150B")]
			[Address(RVA = "0x66CD", Offset = "0x66CD", VA = "0x66CD")]
			set
			{
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150C")]
		[Address(RVA = "0x66CE", Offset = "0x66CE", VA = "0x66CE")]
		private void Awake()
		{
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150D")]
		[Address(RVA = "0x66CF", Offset = "0x66CF", VA = "0x66CF")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150E")]
		[Address(RVA = "0x66D0", Offset = "0x66D0", VA = "0x66D0")]
		public void Init(string title)
		{
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x66D1", Offset = "0x66D1", VA = "0x66D1")]
		public void Init(GreatRewardSets set, UserData user)
		{
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x66D2", Offset = "0x66D2", VA = "0x66D2")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001511")]
		[Address(RVA = "0x66D3", Offset = "0x66D3", VA = "0x66D3")]
		public GiftListElement()
		{
		}

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4000B1E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4000B1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4000B20")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Price _price;

		// Token: 0x04000B21 RID: 2849
		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _button;

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _backupTitle;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x02000387 RID: 903
		[Token(Token = "0x2000387")]
		public enum State
		{
			// Token: 0x04000B27 RID: 2855
			[Token(Token = "0x4000B27")]
			UNKNOWN_STATE,
			// Token: 0x04000B28 RID: 2856
			[Token(Token = "0x4000B28")]
			IDLE,
			// Token: 0x04000B29 RID: 2857
			[Token(Token = "0x4000B29")]
			ASSIGNED
		}
	}
}
