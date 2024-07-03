-- Inserir artistas
INSERT INTO ArtistModel (Name) VALUES ('Rihanna');
INSERT INTO ArtistModel (Name) VALUES ('Linkin Park');
INSERT INTO ArtistModel (Name) VALUES ('Queen');
INSERT INTO ArtistModel (Name) VALUES ('Selena Gomez');
INSERT INTO ArtistModel (Name) VALUES ('AJR');

-- Inserir álbuns para cada artista
INSERT INTO AlbumModel (Title, PublishedAt, ArtistId, UrlCover) VALUES ('Good Girl Gone Bad', '2007-05-30', 1, 'https://rovimusic.rovicorp.com/image.jpg?c=xcWPSVzamJbpFDU9SOhSGgSijaXJlYnq0St31qpAJWo=&f=4');
INSERT INTO AlbumModel (Title, PublishedAt, ArtistId, UrlCover) VALUES ('Hybrid Theory', '2000-10-24', 2, 'https://upload.wikimedia.org/wikipedia/en/thumb/2/2a/Linkin_Park_Hybrid_Theory_Album_Cover.jpg/220px-Linkin_Park_Hybrid_Theory_Album_Cover.jpg');
INSERT INTO AlbumModel (Title, PublishedAt, ArtistId, UrlCover) VALUES ('A Night at the Opera', '1975-11-21', 3, 'https://upload.wikimedia.org/wikipedia/en/thumb/4/4d/Queen_A_Night_At_The_Opera.png/220px-Queen_A_Night_At_The_Opera.png');
INSERT INTO AlbumModel (Title, PublishedAt, ArtistId, UrlCover) VALUES ('Revival', '2015-10-09', 4, 'https://imusic.b-cdn.net/images/item/original/447/0602435357447.jpg?selena-gomez-revival-5-tracks-cd&class=scaled&v=1697033381');
INSERT INTO AlbumModel (Title, PublishedAt, ArtistId, UrlCover) VALUES ('The Click', '2017-06-09', 5, 'https://m.media-amazon.com/images/I/91B7UIQ6xNL._UF1000,1000_QL80_.jpg');

-- Inserir músicas para cada álbum
-- Rihanna
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Umbrella', 1, 'Pop', 267);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Dont Stop the Music', 1, 'Pop', 247);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Take a Bow', 1, 'Pop', 231);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Disturbia', 1, 'Pop', 242);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Shut Up and Drive', 1, 'Pop', 213);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Rehab', 1, 'Pop', 244);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Hate That I Love You', 1, 'Pop', 232);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Unfaithful', 1, 'Pop', 220);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('SOS', 1, 'Pop', 214);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('We Ride', 1, 'Pop', 211);

-- Linkin Park
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('In the End', 2, 'Rock', 216);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Crawling', 2, 'Rock', 209);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Papercut', 2, 'Rock', 185);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('One Step Closer', 2, 'Rock', 157);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Points of Authority', 2, 'Rock', 198);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Runaway', 2, 'Rock', 187);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('By Myself', 2, 'Rock', 189);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('A Place for My Head', 2, 'Rock', 208);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Forgotten', 2, 'Rock', 199);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Pushing Me Away', 2, 'Rock', 201);

-- Queen
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Bohemian Rhapsody', 3, 'Rock', 354);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Love of My Life', 3, 'Rock', 219);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Youre My Best Friend', 3, 'Rock', 171);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Im in Love with My Car', 3, 'Rock', 186);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('God Save the Queen', 3, 'Rock', 73);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Sweet Lady', 3, 'Rock', 238);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Seaside Rendezvous', 3, 'Rock', 139);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('The Prophets Song', 3, 'Rock', 498);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Good Company', 3, 'Rock', 199);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Lazing on a Sunday Afternoon', 3, 'Rock', 70);

-- Selena Gomez
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Same Old Love', 4, 'Pop', 234);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Hands to Myself', 4, 'Pop', 195);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Good for You', 4, 'Pop', 220);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Kill Em with Kindness', 4, 'Pop', 223);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Revival', 4, 'Pop', 239);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Sober', 4, 'Pop', 215);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Camouflage', 4, 'Pop', 248);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Me & the Rhythm', 4, 'Pop', 192);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Survivors', 4, 'Pop', 212);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Rise', 4, 'Pop', 205);

-- AJR
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Weak', 5, 'Indie Pop', 213);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Sober Up', 5, 'Indie Pop', 202);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Drama', 5, 'Indie Pop', 199);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Turning Out', 5, 'Indie Pop', 210);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('No Grass Today', 5, 'Indie Pop', 197);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Three-Thirty', 5, 'Indie Pop', 209);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Call My Dad', 5, 'Indie Pop', 225);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Im Not Famous', 5, 'Indie Pop', 202);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Netflix Trip', 5, 'Indie Pop', 187);
INSERT INTO Music (Title, AlbumId, Genre, Duration) VALUES ('Bud Like You', 5, 'Indie Pop', 194);
