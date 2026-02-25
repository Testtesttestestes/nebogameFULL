using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UI.Preloader;
using UnityEngine;

namespace Preloading
{
	// Token: 0x02000E37 RID: 3639
	[Token(Token = "0x2000E37")]
	public class Preloader : MonoBehaviour
	{
		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06005927 RID: 22823 RVA: 0x0000FD98 File Offset: 0x0000DF98
		// (set) Token: 0x06005928 RID: 22824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700122B")]
		private float SumStepsWeights
		{
			[Token(Token = "0x6005927")]
			[Address(RVA = "0xA679", Offset = "0xA679", VA = "0xA679")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005928")]
			[Address(RVA = "0xA67A", Offset = "0xA67A", VA = "0xA67A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06005929 RID: 22825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700122C")]
		public PreloaderView PreloaderView
		{
			[Token(Token = "0x6005929")]
			[Address(RVA = "0xA67B", Offset = "0xA67B", VA = "0xA67B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592A")]
		[Address(RVA = "0xA67C", Offset = "0xA67C", VA = "0xA67C")]
		private void Awake()
		{
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600592B")]
		[Address(RVA = "0xA67D", Offset = "0xA67D", VA = "0xA67D")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592C")]
		[Address(RVA = "0xA67E", Offset = "0xA67E", VA = "0xA67E")]
		private static void ApplicationOnLogMessageReceived(string condition, string stacktrace, LogType type)
		{
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592D")]
		[Address(RVA = "0x227D", Offset = "0x227D", VA = "0x227D")]
		public void Hide()
		{
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592E")]
		[Address(RVA = "0xA67F", Offset = "0xA67F", VA = "0xA67F")]
		public void Show()
		{
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592F")]
		[Address(RVA = "0xA680", Offset = "0xA680", VA = "0xA680")]
		public void SetProgressOfPart(float progressOfStep, int currentStepIndex)
		{
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005930")]
		[Address(RVA = "0xA681", Offset = "0xA681", VA = "0xA681")]
		public Preloader()
		{
		}

		// Token: 0x04003024 RID: 12324
		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PreloaderView _preloaderView;

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x14")]
		private readonly float[] StepsWeights;
	}
}
