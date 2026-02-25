using System;
using GAFInternal.Data;
using GAFInternal.Objects;
using Il2CppDummyDll;
using UnityEngine;

namespace GAF.Objects
{
	// Token: 0x020013DC RID: 5084
	[Token(Token = "0x20013DC")]
	[Serializable]
	public class GAFBakedObject : GAFBakedObjectInternal
	{
		// Token: 0x06007969 RID: 31081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007969")]
		[Address(RVA = "0xC249", Offset = "0xC249", VA = "0xC249")]
		public void addController()
		{
		}

		// Token: 0x0600796A RID: 31082 RVA: 0x000165C0 File Offset: 0x000147C0
		[Token(Token = "0x600796A")]
		[Address(RVA = "0xC24A", Offset = "0xC24A", VA = "0xC24A")]
		public bool hasController()
		{
			return default(bool);
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600796B")]
		[Address(RVA = "0x190E", Offset = "0x190E", VA = "0x190E")]
		public void removeController()
		{
		}

		// Token: 0x0600796C RID: 31084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600796C")]
		[Address(RVA = "0xC24B", Offset = "0xC24B", VA = "0xC24B", Slot = "13")]
		public override void reload()
		{
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600796D")]
		[Address(RVA = "0xC24C", Offset = "0xC24C", VA = "0xC24C", Slot = "14")]
		public override void updateToState(GAFObjectStateData _State, bool _Refresh)
		{
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600796E")]
		[Address(RVA = "0xC24D", Offset = "0xC24D", VA = "0xC24D")]
		public GAFBakedObject()
		{
		}

		// Token: 0x04003F5D RID: 16221
		[Token(Token = "0x4003F5D")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[SerializeField]
		private GAFBakedObjectController m_Controller;
	}
}
