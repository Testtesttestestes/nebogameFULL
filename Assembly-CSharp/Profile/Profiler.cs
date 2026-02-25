using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using Unity.Profiling;
using UnityEngine;

namespace Profile
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	public class Profiler : MonoBehaviour
	{
		// Token: 0x06000718 RID: 1816 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x5B10", Offset = "0x5B10", VA = "0x5B10")]
		private static string BytesToMB(double value)
		{
			return null;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x5B11", Offset = "0x5B11", VA = "0x5B11")]
		private static string CountToString(double value)
		{
			return null;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x5B12", Offset = "0x5B12", VA = "0x5B12")]
		private void Awake()
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x5B13", Offset = "0x5B13", VA = "0x5B13")]
		private IEnumerator CollectStatsCoroutine()
		{
			return null;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x5B14", Offset = "0x5B14", VA = "0x5B14")]
		private void OnEnable()
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x5B15", Offset = "0x5B15", VA = "0x5B15")]
		private void OnDisable()
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x5B16", Offset = "0x5B16", VA = "0x5B16")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x5B17", Offset = "0x5B17", VA = "0x5B17")]
		public Profiler()
		{
		}

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _stats;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x14")]
		private StringBuilder _output;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x18")]
		private ProfilerRecorder[] _recorders;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x1C")]
		[TupleElementNames(new string[]
		{
			"Name",
			"Format"
		})]
		private ValueTuple<string, Func<double, string>>[] _recorderNames;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine _routine;
	}
}
