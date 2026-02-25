using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x20003C7")]
	public class WorldIndexButtonsView : MonoBehaviour
	{
		// Token: 0x14000112 RID: 274
		// (add) Token: 0x060016AC RID: 5804 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060016AD RID: 5805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000112")]
		public event Action HomeButtonClickedEvent
		{
			[Token(Token = "0x60016AC")]
			[Address(RVA = "0x686D", Offset = "0x686D", VA = "0x686D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60016AD")]
			[Address(RVA = "0x686E", Offset = "0x686E", VA = "0x686E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000113 RID: 275
		// (add) Token: 0x060016AE RID: 5806 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060016AF RID: 5807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000113")]
		public event Action ZigguratButtonClickedEvent
		{
			[Token(Token = "0x60016AE")]
			[Address(RVA = "0x686F", Offset = "0x686F", VA = "0x686F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60016AF")]
			[Address(RVA = "0x6870", Offset = "0x6870", VA = "0x6870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x6871", Offset = "0x6871", VA = "0x6871")]
		private void Awake()
		{
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x6872", Offset = "0x6872", VA = "0x6872")]
		private void OnDestroy()
		{
		}

		// Token: 0x170003D6 RID: 982
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D6")]
		public bool HomeButtonEnabled
		{
			[Token(Token = "0x60016B2")]
			[Address(RVA = "0x6873", Offset = "0x6873", VA = "0x6873")]
			set
			{
			}
		}

		// Token: 0x170003D7 RID: 983
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D7")]
		public bool ZigguratButtonEnabled
		{
			[Token(Token = "0x60016B3")]
			[Address(RVA = "0x6874", Offset = "0x6874", VA = "0x6874")]
			set
			{
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x6875", Offset = "0x6875", VA = "0x6875")]
		public WorldIndexButtonsView()
		{
		}

		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _homeButton;

		// Token: 0x04000BF7 RID: 3063
		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _zigguratButton;
	}
}
