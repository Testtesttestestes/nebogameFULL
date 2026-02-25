using System;
using Core.Data;
using Gameplay.GdEvents.Model.Milestone;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent
{
	// Token: 0x02000724 RID: 1828
	[Token(Token = "0x2000724")]
	public class ArtkulsStageContentGroupView : AbstractStageContentGroupView<ArtikulData>
	{
		// Token: 0x06002BC0 RID: 11200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC0")]
		[Address(RVA = "0x7C51", Offset = "0x7C51", VA = "0x7C51", Slot = "4")]
		protected override void HandleDataChanged(StageContentData<ArtikulData> fromData, StageContentData<ArtikulData> toData)
		{
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC1")]
		[Address(RVA = "0x7C52", Offset = "0x7C52", VA = "0x7C52")]
		public ArtkulsStageContentGroupView()
		{
		}

		// Token: 0x040017F1 RID: 6129
		[Token(Token = "0x40017F1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ArtikulView _artikulPrefab;
	}
}
