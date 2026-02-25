using System;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay.GdEvents.View.Milestone.Activity
{
	// Token: 0x02000732 RID: 1842
	[Token(Token = "0x2000732")]
	public class GameActivityContentGroupView : AbstractContentGroupView
	{
		// Token: 0x06002BF5 RID: 11253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF5")]
		[Address(RVA = "0x7C86", Offset = "0x7C86", VA = "0x7C86")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085E")]
		public ActivityGroupData Data
		{
			[Token(Token = "0x6002BF6")]
			[Address(RVA = "0x7C87", Offset = "0x7C87", VA = "0x7C87")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BF7")]
			[Address(RVA = "0x7C88", Offset = "0x7C88", VA = "0x7C88")]
			set
			{
			}
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x218A", Offset = "0x218A", VA = "0x218A")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x7C89", Offset = "0x7C89", VA = "0x7C89")]
		private void HandleItemClickEvent(GameActivityData activity)
		{
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x7C8A", Offset = "0x7C8A", VA = "0x7C8A")]
		private void Clear()
		{
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x7C8B", Offset = "0x7C8B", VA = "0x7C8B")]
		public GameActivityContentGroupView()
		{
		}

		// Token: 0x04001813 RID: 6163
		[Token(Token = "0x4001813")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _content;

		// Token: 0x04001814 RID: 6164
		[Token(Token = "0x4001814")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActivityView _activityPrefab;

		// Token: 0x04001815 RID: 6165
		[Token(Token = "0x4001815")]
		[FieldOffset(Offset = "0x1C")]
		[NonSerialized]
		public UnityEvent<GameActivityData> ItemClickEvent;

		// Token: 0x04001816 RID: 6166
		[Token(Token = "0x4001816")]
		[FieldOffset(Offset = "0x20")]
		private ActivityGroupData _data;
	}
}
