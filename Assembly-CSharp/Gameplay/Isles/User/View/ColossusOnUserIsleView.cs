using System;
using Gameplay.Isles.Axis.View;
using Gameplay.Isles.User.Controller;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D10 RID: 3344
	[Token(Token = "0x2000D10")]
	public class ColossusOnUserIsleView : MonoBehaviour
	{
		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x0600519A RID: 20890 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001085")]
		public ColossusInWorldView ColossusView
		{
			[Token(Token = "0x600519A")]
			[Address(RVA = "0x9F76", Offset = "0x9F76", VA = "0x9F76")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600519B")]
		[Address(RVA = "0x9F77", Offset = "0x9F77", VA = "0x9F77")]
		public void Init(UserIsle isle)
		{
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600519C")]
		[Address(RVA = "0x9F78", Offset = "0x9F78", VA = "0x9F78")]
		public void Deinit()
		{
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600519D")]
		[Address(RVA = "0x9F79", Offset = "0x9F79", VA = "0x9F79")]
		public ColossusOnUserIsleView()
		{
		}

		// Token: 0x04002C5D RID: 11357
		[Token(Token = "0x4002C5D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ColossusInWorldView _colossusView;

		// Token: 0x04002C5E RID: 11358
		[Token(Token = "0x4002C5E")]
		[FieldOffset(Offset = "0x14")]
		private ColossusOnUserIsleViewMediator _mediator;
	}
}
