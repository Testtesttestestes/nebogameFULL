using System;
using System.Collections.Generic;
using GAFInternal.Core;
using GAFInternal.Data;
using Il2CppDummyDll;
using UnityEngine;

namespace GAFInternal.Objects
{
	// Token: 0x020013D6 RID: 5078
	[Token(Token = "0x20013D6")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(GAFSortingManager))]
	[Serializable]
	public class GAFObjectsManagerInternal<TypeOfObject> : GAFBaseObjectsManager where TypeOfObject : GAFObjectInternal
	{
		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06007919 RID: 31001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017FC")]
		public override GAFBaseClip clip
		{
			[Token(Token = "0x6007919")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x0600791A RID: 31002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017FD")]
		public override List<IGAFObject> objects
		{
			[Token(Token = "0x600791A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x0600791B RID: 31003 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017FE")]
		public override Dictionary<uint, IGAFObject> objectsDict
		{
			[Token(Token = "0x600791B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600791C")]
		public override void initialize()
		{
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600791D")]
		public override void reload()
		{
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600791E")]
		public override void cleanView()
		{
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600791F")]
		public override void clear()
		{
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007920")]
		public override void deepClear()
		{
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007921")]
		public sealed override void updateToFrame(Dictionary<uint, GAFObjectStateData> _States, bool _Refresh)
		{
		}

		// Token: 0x06007922 RID: 31010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007922")]
		public sealed override void updateToKeyFrame(List<GAFObjectStateData> _States)
		{
		}

		// Token: 0x06007923 RID: 31011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007923")]
		protected sealed override void createObjects()
		{
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007924")]
		private TypeOfObject createObject(string _Name, ObjectBehaviourType _Type, GAFObjectData _Data)
		{
			return null;
		}

		// Token: 0x06007925 RID: 31013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007925")]
		public GAFObjectsManagerInternal()
		{
		}

		// Token: 0x04003F40 RID: 16192
		[Token(Token = "0x4003F40")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private GAFBaseClip m_MovieClip;

		// Token: 0x04003F41 RID: 16193
		[Token(Token = "0x4003F41")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private GAFSortingManager m_SortingManager;

		// Token: 0x04003F42 RID: 16194
		[Token(Token = "0x4003F42")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private List<TypeOfObject> m_Objects;

		// Token: 0x04003F43 RID: 16195
		[Token(Token = "0x4003F43")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[NonSerialized]
		private Dictionary<uint, IGAFObject> m_ObjectsDict;
	}
}
