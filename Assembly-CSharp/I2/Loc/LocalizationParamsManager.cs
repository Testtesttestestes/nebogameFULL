using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020013A7 RID: 5031
	[Token(Token = "0x20013A7")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		// Token: 0x060077BF RID: 30655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077BF")]
		[Address(RVA = "0xC11A", Offset = "0xC11A", VA = "0xC11A", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
			return null;
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C0")]
		[Address(RVA = "0xC11B", Offset = "0xC11B", VA = "0xC11B")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C1")]
		[Address(RVA = "0xC11C", Offset = "0xC11C", VA = "0xC11C")]
		public void OnLocalize()
		{
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C2")]
		[Address(RVA = "0xC11D", Offset = "0xC11D", VA = "0xC11D", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C3")]
		[Address(RVA = "0xC11E", Offset = "0xC11E", VA = "0xC11E")]
		public void DoAutoRegister()
		{
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C4")]
		[Address(RVA = "0xC11F", Offset = "0xC11F", VA = "0xC11F")]
		public void OnDisable()
		{
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C5")]
		[Address(RVA = "0xC120", Offset = "0xC120", VA = "0xC120")]
		public LocalizationParamsManager()
		{
		}

		// Token: 0x04003E7C RID: 15996
		[Token(Token = "0x4003E7C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public List<LocalizationParamsManager.ParamValue> _Params;

		// Token: 0x04003E7D RID: 15997
		[Token(Token = "0x4003E7D")]
		[FieldOffset(Offset = "0x14")]
		public bool _IsGlobalManager;

		// Token: 0x020013A8 RID: 5032
		[Token(Token = "0x20013A8")]
		[Serializable]
		public struct ParamValue
		{
			// Token: 0x04003E7E RID: 15998
			[Token(Token = "0x4003E7E")]
			[FieldOffset(Offset = "0x0")]
			public string Name;

			// Token: 0x04003E7F RID: 15999
			[Token(Token = "0x4003E7F")]
			[FieldOffset(Offset = "0x4")]
			public string Value;
		}
	}
}
