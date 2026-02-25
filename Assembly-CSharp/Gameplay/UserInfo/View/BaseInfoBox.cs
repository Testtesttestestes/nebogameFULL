using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003EF RID: 1007
	[Token(Token = "0x20003EF")]
	public abstract class BaseInfoBox : MonoBehaviour
	{
		// Token: 0x06001791 RID: 6033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001791")]
		[Address(RVA = "0x694D", Offset = "0x694D", VA = "0x694D")]
		private void OnDisable()
		{
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001792")]
		[Address(RVA = "0x694E", Offset = "0x694E", VA = "0x694E")]
		private void OnEnable()
		{
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x000055E0 File Offset: 0x000037E0
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000413")]
		public bool Visible
		{
			[Token(Token = "0x6001793")]
			[Address(RVA = "0x694F", Offset = "0x694F", VA = "0x694F")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001794")]
			[Address(RVA = "0x6950", Offset = "0x6950", VA = "0x6950")]
			set
			{
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001795")]
		[Address(RVA = "0x6951", Offset = "0x6951", VA = "0x6951", Slot = "4")]
		protected virtual void HandleVisibleChanged()
		{
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x6001796")]
		[Address(RVA = "0x6952", Offset = "0x6952", VA = "0x6952")]
		public bool SwitchVisible()
		{
			return default(bool);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001797")]
		[Address(RVA = "0x6953", Offset = "0x6953", VA = "0x6953")]
		public void RemoveAll()
		{
		}

		// Token: 0x06001798 RID: 6040
		[Token(Token = "0x6001798")]
		public abstract void UpdateInfo();

		// Token: 0x06001799 RID: 6041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x6954", Offset = "0x6954", VA = "0x6954")]
		protected BaseInfoBox()
		{
		}

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Transform _content;

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x14")]
		private bool _visible;
	}
}
