using System;
using Gameplay.Boss.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;

namespace Gameplay.Boss.View.RatingTab
{
	// Token: 0x02000B67 RID: 2919
	[Token(Token = "0x2000B67")]
	public class BossTopLeaderView : MonoBehaviour
	{
		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046CF RID: 18127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E10")]
		public BossCaptainRatingData CaptainRating
		{
			[Token(Token = "0x60046CE")]
			[Address(RVA = "0x9564", Offset = "0x9564", VA = "0x9564")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046CF")]
			[Address(RVA = "0x9565", Offset = "0x9565", VA = "0x9565")]
			set
			{
			}
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046D0")]
		[Address(RVA = "0x9566", Offset = "0x9566", VA = "0x9566")]
		private void DataOnCaptainUserDataChangedEvent()
		{
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x9567", Offset = "0x9567", VA = "0x9567")]
		private void OnDestroy()
		{
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046D2")]
		[Address(RVA = "0x9568", Offset = "0x9568", VA = "0x9568")]
		public BossTopLeaderView()
		{
		}

		// Token: 0x040026C9 RID: 9929
		[Token(Token = "0x40026C9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x040026CA RID: 9930
		[Token(Token = "0x40026CA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LevelCounter _levelCounter;

		// Token: 0x040026CB RID: 9931
		[Token(Token = "0x40026CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _nickname;

		// Token: 0x040026CC RID: 9932
		[Token(Token = "0x40026CC")]
		[FieldOffset(Offset = "0x1C")]
		private BossCaptainRatingData _captainRating;
	}
}
