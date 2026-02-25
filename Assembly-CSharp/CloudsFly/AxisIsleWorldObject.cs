using System;
using Gameplay.Isles.Axis.View;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012E9 RID: 4841
	[Token(Token = "0x20012E9")]
	public class AxisIsleWorldObject : BaseIsleWorldObject
	{
		// Token: 0x06007345 RID: 29509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007345")]
		[Address(RVA = "0xBD4E", Offset = "0xBD4E", VA = "0xBD4E", Slot = "12")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007346")]
		[Address(RVA = "0xBD4F", Offset = "0xBD4F", VA = "0xBD4F", Slot = "13")]
		public override void UpdateOrder()
		{
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007347")]
		[Address(RVA = "0xBD50", Offset = "0xBD50", VA = "0xBD50", Slot = "14")]
		public override void Reset()
		{
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007348")]
		[Address(RVA = "0xBD51", Offset = "0xBD51", VA = "0xBD51")]
		public AxisIsleWorldObject()
		{
		}

		// Token: 0x04003C58 RID: 15448
		[Token(Token = "0x4003C58")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private AxisIsleView _axisIsleView;
	}
}
