using System;
using Core.Net.Monitor.Responseability;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace UI.Informer.Network
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	public class LowNetworkResponseAbilityInformerView : MonoBehaviour
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x5F66", Offset = "0x5F66", VA = "0x5F66")]
		public void SetStatus(ResponseAbilityStatus status)
		{
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x5F67", Offset = "0x5F67", VA = "0x5F67")]
		private bool TryNotifyAboutCriticalStatus(ResponseAbilityStatus status)
		{
			return default(bool);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x5F68", Offset = "0x5F68", VA = "0x5F68")]
		public LowNetworkResponseAbilityInformerView()
		{
		}

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private WarnIconView _warnImage;

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x14")]
		private DialogWindow _dialog;
	}
}
