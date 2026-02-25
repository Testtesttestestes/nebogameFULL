using System;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent
{
	// Token: 0x02000723 RID: 1827
	[Token(Token = "0x2000723")]
	public abstract class AbstractStageContentGroupView<T> : AbstractContentGroupView where T : class
	{
		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000854")]
		public Transform Content
		{
			[Token(Token = "0x6002BBA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BBC RID: 11196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000855")]
		public StageContentData<T> Data
		{
			[Token(Token = "0x6002BBB")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BBC")]
			set
			{
			}
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BBD")]
		public void ClearContent()
		{
		}

		// Token: 0x06002BBE RID: 11198
		[Token(Token = "0x6002BBE")]
		protected abstract void HandleDataChanged(StageContentData<T> fromData, StageContentData<T> toData);

		// Token: 0x06002BBF RID: 11199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BBF")]
		protected AbstractStageContentGroupView()
		{
		}

		// Token: 0x040017EF RID: 6127
		[Token(Token = "0x40017EF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform _content;

		// Token: 0x040017F0 RID: 6128
		[Token(Token = "0x40017F0")]
		[FieldOffset(Offset = "0x0")]
		private StageContentData<T> _data;
	}
}
