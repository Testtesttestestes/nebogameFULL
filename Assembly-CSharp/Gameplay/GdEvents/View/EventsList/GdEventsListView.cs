using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x0200073F RID: 1855
	[Token(Token = "0x200073F")]
	public class GdEventsListView : MonoBehaviour
	{
		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000865")]
		public GdEventsListOsaView List
		{
			[Token(Token = "0x6002C2D")]
			[Address(RVA = "0x7CBD", Offset = "0x7CBD", VA = "0x7CBD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000866")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002C2E")]
			[Address(RVA = "0x7CBE", Offset = "0x7CBE", VA = "0x7CBE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x7CBF", Offset = "0x7CBF", VA = "0x7CBF")]
		public GdEventsListView()
		{
		}

		// Token: 0x04001837 RID: 6199
		[Token(Token = "0x4001837")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001838 RID: 6200
		[Token(Token = "0x4001838")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GdEventsListOsaView _list;
	}
}
