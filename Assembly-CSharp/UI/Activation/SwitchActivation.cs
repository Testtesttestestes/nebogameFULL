using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Activation
{
	// Token: 0x0200025B RID: 603
	[Token(Token = "0x200025B")]
	public class SwitchActivation : MonoBehaviour
	{
		// Token: 0x06000E8E RID: 3726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x610F", Offset = "0x610F", VA = "0x610F")]
		public void SwitchActive()
		{
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x6110", Offset = "0x6110", VA = "0x6110")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x6111", Offset = "0x6111", VA = "0x6111")]
		public void DelayedSetActive(bool active)
		{
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x6112", Offset = "0x6112", VA = "0x6112")]
		private IEnumerator DelayedSetActiveRoutine(bool active, int delayFrames = 1)
		{
			return null;
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x6113", Offset = "0x6113", VA = "0x6113")]
		public SwitchActivation()
		{
		}
	}
}
