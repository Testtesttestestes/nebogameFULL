using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Monsters
{
	// Token: 0x02000728 RID: 1832
	[Token(Token = "0x2000728")]
	public class MonsterView : MonoBehaviour
	{
		// Token: 0x14000160 RID: 352
		// (add) Token: 0x06002BC8 RID: 11208 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002BC9 RID: 11209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000160")]
		public event Action<MonsterData> ClickEvent
		{
			[Token(Token = "0x6002BC8")]
			[Address(RVA = "0x7C59", Offset = "0x7C59", VA = "0x7C59")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002BC9")]
			[Address(RVA = "0x7C5A", Offset = "0x7C5A", VA = "0x7C5A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0x7C5B", Offset = "0x7C5B", VA = "0x7C5B")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0x7C5C", Offset = "0x7C5C", VA = "0x7C5C")]
		private void Awake()
		{
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0x7C5D", Offset = "0x7C5D", VA = "0x7C5D")]
		private void AprOnClickEvent(AprView obj)
		{
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BCE RID: 11214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000857")]
		public MonsterData Data
		{
			[Token(Token = "0x6002BCD")]
			[Address(RVA = "0x7C5E", Offset = "0x7C5E", VA = "0x7C5E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BCE")]
			[Address(RVA = "0x7C5F", Offset = "0x7C5F", VA = "0x7C5F")]
			set
			{
			}
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCF")]
		[Address(RVA = "0x7C60", Offset = "0x7C60", VA = "0x7C60")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD0")]
		[Address(RVA = "0x7C61", Offset = "0x7C61", VA = "0x7C61")]
		public MonsterView()
		{
		}

		// Token: 0x040017FD RID: 6141
		[Token(Token = "0x40017FD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040017FE RID: 6142
		[Token(Token = "0x40017FE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LevelCounter _level;

		// Token: 0x040017FF RID: 6143
		[Token(Token = "0x40017FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AprView _apr;

		// Token: 0x04001801 RID: 6145
		[Token(Token = "0x4001801")]
		[FieldOffset(Offset = "0x20")]
		private MonsterData _data;
	}
}
