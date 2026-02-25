using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F9 RID: 1017
	[Token(Token = "0x20003F9")]
	public class MarkersView : MonoBehaviour
	{
		// Token: 0x060017DD RID: 6109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DD")]
		[Address(RVA = "0x6998", Offset = "0x6998", VA = "0x6998")]
		public void Init(IList<uint> markerIds, Dictionaries dict)
		{
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DE")]
		[Address(RVA = "0x6999", Offset = "0x6999", VA = "0x6999")]
		public MarkersView()
		{
		}

		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MarkerListElement _listElementPrefab;

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;
	}
}
