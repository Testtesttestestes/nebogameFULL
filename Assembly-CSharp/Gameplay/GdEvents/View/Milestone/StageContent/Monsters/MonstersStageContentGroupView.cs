using System;
using Core.Data;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Monsters
{
	// Token: 0x02000729 RID: 1833
	[Token(Token = "0x2000729")]
	public class MonstersStageContentGroupView : AbstractStageContentGroupView<MonsterData>
	{
		// Token: 0x06002BD1 RID: 11217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD1")]
		[Address(RVA = "0x7C62", Offset = "0x7C62", VA = "0x7C62")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD2")]
		[Address(RVA = "0x7C63", Offset = "0x7C63", VA = "0x7C63", Slot = "4")]
		protected override void HandleDataChanged(StageContentData<MonsterData> fromData, StageContentData<MonsterData> toData)
		{
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD3")]
		[Address(RVA = "0x7C64", Offset = "0x7C64", VA = "0x7C64")]
		private void HandleClickEvent(MonsterData data)
		{
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD4")]
		[Address(RVA = "0x7C65", Offset = "0x7C65", VA = "0x7C65")]
		public MonstersStageContentGroupView()
		{
		}

		// Token: 0x04001802 RID: 6146
		[Token(Token = "0x4001802")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private MonsterView _monsterPrefab;
	}
}
