using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.VortexRating.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.VortexRating.View.GreatOnesTab
{
	// Token: 0x02000391 RID: 913
	[Token(Token = "0x2000391")]
	public class GreatOnesView : MonoBehaviour
	{
		// Token: 0x1400010E RID: 270
		// (add) Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600153E RID: 5438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400010E")]
		public event Action<GreatUserView> LikeButtonClickedEvent
		{
			[Token(Token = "0x600153D")]
			[Address(RVA = "0x66FF", Offset = "0x66FF", VA = "0x66FF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600153E")]
			[Address(RVA = "0x6700", Offset = "0x6700", VA = "0x6700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000380")]
		public TextMeshProUGUI RatingPointsText
		{
			[Token(Token = "0x600153F")]
			[Address(RVA = "0x6701", Offset = "0x6701", VA = "0x6701")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001540")]
		[Address(RVA = "0x6702", Offset = "0x6702", VA = "0x6702")]
		private void Start()
		{
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001541")]
		[Address(RVA = "0x6703", Offset = "0x6703", VA = "0x6703")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001542")]
		[Address(RVA = "0x6704", Offset = "0x6704", VA = "0x6704")]
		private void LikeButtonClickedEventHandler(GreatUserView user)
		{
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x6705", Offset = "0x6705", VA = "0x6705")]
		public GreatUserView[] Init(IList<GreatUserData> userDatas)
		{
			return null;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x6706", Offset = "0x6706", VA = "0x6706")]
		public GreatOnesView()
		{
		}

		// Token: 0x04000B4C RID: 2892
		[Token(Token = "0x4000B4C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GreatUserView[] _greatUsers;

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4000B4D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _ratingPointsText;
	}
}
